using BusarovsQuickBite.Core.Models.Cart;
using BusarovsQuickBite.Core.Models.Product;
using BusarovsQuickBite.Infrastructure.Data.Models;

namespace BusarovsQuickBite.Core.Contracts
{
    public interface ICartService
    {
        Task<CartViewModel> GetCart(string userId);
        Task AddCartProduct(int productId, string userId);
        Task<List<ProductViewModel>> FindProductsForUserAndCart(string userId);
        Task RemoveProductFromCart(int productId, string userId);
        Task<Cart> GetCartByUserId(string userId);
    }
}
