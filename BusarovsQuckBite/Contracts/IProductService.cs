using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;

namespace BusarovsQuckBite.Contracts
{
    public interface IProductService
    {
        Task<(ProductAllViewModel,int)> GetAllProductsAsync(int pageSize, int page, string? category,FilterEnum filter);
        Task AddProduct(ProductFormViewModel model, string userId);
        Task DeleteProduct(int id);
        Task<Product> GetProductByIdAsync(int productId);
    }
}
