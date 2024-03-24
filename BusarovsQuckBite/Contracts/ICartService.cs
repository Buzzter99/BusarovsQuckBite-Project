using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace BusarovsQuckBite.Contracts
{
    public interface ICartService
    {
        Task<CartViewModel> GetCart(string userId);
        Task AddCartProduct(int productId, string userId);
        Task<List<ProductViewModel>> FindProductsForUserAndCart(string userId);
        Task RemoveProductFromCart(int productId, string userId);
    }
}
