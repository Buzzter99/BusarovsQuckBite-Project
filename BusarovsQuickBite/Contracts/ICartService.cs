using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Cart;
using BusarovsQuckBite.Models.Product;

namespace BusarovsQuckBite.Contracts
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
