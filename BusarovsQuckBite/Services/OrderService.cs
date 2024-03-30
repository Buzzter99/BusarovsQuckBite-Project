using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Enums;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Services
{
    public class OrderService : IOrderService
    {
        private readonly ICartService _cartService;
        private readonly IAddressService _addressService;
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;

        public OrderService(ICartService cartService, IAddressService addressService, ApplicationDbContext context, IProductService productService)
        {
            _cartService = cartService;
            _addressService = addressService;
            _context = context;
            _productService = productService;
        }

        public async Task<int> GetOrderStatus(int id, string userId)
        {
            var model = await _context.Orders.Where(x => x.Id == id && x.Who == userId).FirstOrDefaultAsync();
            if (model == null)
            {
                throw new ApplicationException("Order not found!");
            }
            return (int)model.Status;
        }
        public async Task<OrderViewModel> ValidateOrderAsync(OrderViewModel model, string userId)
        {
            if (model.Cart.ProductAll.Count <= 0)
            {
                throw new ApplicationException("Cart is empty!");
            }
            var userCart = await _cartService.FindProductsForUserAndCart(userId);
            bool listsAreEqual = userCart.OrderBy(x => x.Id).Select(c => c.Id).SequenceEqual(model.Cart.ProductAll.OrderBy(x => x.Id).Select(c => c.Id));
            if (!listsAreEqual)
            {
                throw new ApplicationException("Invalid Cart Items!");
            }
            foreach (var product in model.Cart.ProductAll)
            {
                var dbProduct = userCart.First(x => x.Id == product.Id);
                if (product.QtyWanted <= 0)
                {
                    throw new ApplicationException("Quantity must be greater than 0!");
                }
                if (product.QtyWanted > dbProduct.QtyAvailable)
                {
                    throw new ApplicationException("Quantity must be greater than 0!");
                }
                dbProduct.QtyWanted = product.QtyWanted;

            }
            if (model.SelectedAddressId != null)
            {
                await _addressService.GetByIdForUser((int)model.SelectedAddressId, userId);
            }
            return new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    CartOwner = userId,
                    ProductAll = userCart
                },
                PaymentType = EnumHelper.GetEnumSelectList<PaymentType>(),
                Addresses = await _addressService.GetActiveAddressesForUser(userId),
                SelectedAddressId = model.SelectedAddressId,
                PaymentTypeValue = model.PaymentTypeValue
            };
        }
        public async Task<int> PlaceOrder(OrderViewModel model, string userId)
        {
            if (model.Cart.CartOwner != userId)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.OwnerIsInvalid);
            }
            await _addressService.GetByIdForUser((int)model.SelectedAddressId!, userId);
            int orderId = await CreateAndGetOrderId(model, userId);
            await DeleteCartProducts(model.Cart.ProductAll, userId, orderId);
            return orderId;
        }

        public async Task<AllUserOrdersViewModel> GetOrdersForUser(string userId)
        {
            var collection = await _context.Orders.Where(x => x.Who == userId).OrderByDescending(x => x.TransactionDateAndTime).ThenByDescending(x => x.Status).Select(c => new OrderUserViewModel
            {

                Id = c.Id,
                PaymentType = c.PaymentType,
                OrderPlacedDate = c.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat),
                OrderStatus = c.Status,
                AddressId = c.AddressId,
                OrderWho = c.User.UserName
            }).ToListAsync();
            foreach (var kvp in collection)
            {
                kvp.OrderProducts = await _productService.GetProductsForOrderAsync(kvp.Id);
                kvp.DeliveryAddress = await _addressService.GetByIdForUser(kvp.AddressId, userId);
            }
            var result = new AllUserOrdersViewModel
            {
                OrderModel = collection,
                OrderStatuses = EnumHelper.GetEnumSelectList<OrderStatus>()
            };
            return result;
        }

        private async Task DeleteCartProducts(IEnumerable<ProductViewModel> cartItems, string userId, int orderId)
        {
            var cartService = await _cartService.GetCartByUserId(userId);
            foreach (var kvp in cartItems)
            {
                var entity = await _context.CartProducts.FirstOrDefaultAsync(x => x.CartId == cartService.Id && x.ProductId == kvp.Id);
                if (entity == null)
                {
                    throw new ApplicationException("Product not found in cart!");
                }
                _context.Remove(entity);
                var decreaseQty = await _productService.GetProductByIdAsync(kvp.Id);
                decreaseQty.Quantity -= kvp.QtyWanted;
                OrderProduct orderProduct = new OrderProduct
                {
                    OrderId = orderId,
                    ProductId = decreaseQty.Id,
                    QtyOrdered = kvp.QtyWanted
                };
                await _context.AddAsync(orderProduct);
            }
            await _context.SaveChangesAsync();
        }
        private async Task<int> CreateAndGetOrderId(OrderViewModel model, string userId)
        {
            bool parseSuccess = Enum.TryParse(model.PaymentTypeValue, out PaymentType validPaymentType);
            if (!parseSuccess)
            {
                throw new ApplicationException("Payment Type not supported yet!");
            }
            var order = new Order
            {
                Who = userId,
                TransactionDateAndTime = DateTime.Now,
                Status = OrderStatus.Processing,
                TotalAmount = model.Cart.ProductAll.Sum(x => x.QtyWanted * x.Price),
                PaymentType = validPaymentType,
                AddressId = (int)model.SelectedAddressId!,
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }
    }
}
