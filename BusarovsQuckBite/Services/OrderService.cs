using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Enums;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Services
{
    public class OrderService : IOrderService
    {
        private readonly ICartService _cartService;
        private readonly IAddressService _addressService;
        public OrderService(ICartService cartService, IAddressService addressService)
        {
            _cartService = cartService;
            _addressService = addressService;
        }
        public async Task<OrderViewModel> ValidateOrderAsync(CartViewModel model, string userId)
        {
            if (model.ProductAll.Count <= 0)
            {
                throw new ApplicationException("Cart is empty!");
            }
            var userCart = await _cartService.FindProductsForUserAndCart(userId);
            bool listsAreEqual = userCart.OrderBy(x => x.Id).Select(c => c.Id).SequenceEqual(model.ProductAll.OrderBy(x => x.Id).Select(c => c.Id));
            if (!listsAreEqual)
            {
                throw new ApplicationException("This is not your cart!");
            }
            foreach (var product in model.ProductAll)
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
            return new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    CartOwner = userId,
                    ProductAll = userCart
                },
                PaymentType = EnumHelper.GetEnumSelectList<PaymentType>(),
                Addresses = await _addressService.GetActiveAddressesForUser(userId)
            };
        }
    }
}
