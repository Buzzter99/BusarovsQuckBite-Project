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
        private readonly ApplicationUserManager<ApplicationUser> _userManager;

        public OrderService(ICartService cartService, IAddressService addressService,
            ApplicationDbContext context,
            IProductService productService,
            ApplicationUserManager<ApplicationUser> userManager)
        {
            _cartService = cartService;
            _addressService = addressService;
            _context = context;
            _productService = productService;
            _userManager = userManager;
        }

        public async Task<Order> GetByIdAsync(int id)
        {
            var model = await _context.Orders.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (model == null)
            {
                throw new ApplicationException("Order not found!");
            }
            return model;
        }
        public async Task<int> GetOrderStatusAsync(int id, string userId)
        {
            var model = await GetByIdAsync(id);
            if (model.Who != userId)
            {
                throw new ApplicationException(ErrorMessagesConstants.OwnerIsInvalid);
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
        public async Task<AllUserOrdersViewModel> GetAllOrders()
        {
            var orders = await _context.Orders
                .OrderByDescending(x => x.TransactionDateAndTime)
                .ThenByDescending(x => x.Status).Include(order => order.User)
                .ToListAsync();
            var orderViewModels = new List<OrderUserViewModel>();
            foreach (var order in orders)
            {
                var deliveryAddress = await _addressService.GetByIdForUser(order.AddressId, order.User.Id);
                var orderProducts = await _productService.GetProductsForOrderAsync(order.Id);
                var userViewModel = await _userManager.MapViewModel(order.User);

                var orderViewModel = new OrderUserViewModel
                {
                    Id = order.Id,
                    PaymentType = order.PaymentType,
                    OrderPlacedDate = order.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat),
                    OrderStatus = order.Status,
                    DeliveryAddress = deliveryAddress,
                    OrderProducts = orderProducts,
                    AddressId = order.AddressId,
                    User = userViewModel
                };
                orderViewModels.Add(orderViewModel);
            }
            var result = new AllUserOrdersViewModel
            {
                OrderModel =  orderViewModels,
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

        public async Task UpdateOrderStatus(int orderId, string userId)
        {
            var order = await GetByIdAsync(orderId);
            if (await _userManager.IsInRoleAsyncById(userId, RoleConstants.CookingStaffRoleName))
            {
                if (order.Status == OrderStatus.Processing)
                {
                    order.Status = OrderStatus.Preparing;
                }
                else if (order.Status == OrderStatus.Preparing)
                {
                    order.Status = OrderStatus.ReadyForDelivery;
                }
            }
            if (await _userManager.IsInRoleAsyncById(userId, RoleConstants.DeliveryDriverRoleName))
            {
                if (order.Status == OrderStatus.ReadyForDelivery)
                {
                    order.Status = OrderStatus.OnTheWay;
                }
                else if (order.Status == OrderStatus.OnTheWay)
                {
                    order.Status = OrderStatus.Delivered;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
