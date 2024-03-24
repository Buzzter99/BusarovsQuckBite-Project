using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;

namespace BusarovsQuckBite.Contracts
{
    public interface IProductService
    {
        Task<ProductAllViewModel> GetAllProductsAsync(int pageSize, int page, string? category,FilterEnum filter);
        Task AddProduct(ProductFormViewModel model, string userId);
        Task DeleteProduct(int id);
        Task<Product> GetProductByIdAsync(int productId);
        Task<ProductFormViewModel> MapProductAsync(int id);
        Task EditProductAsync(ProductFormViewModel model);
        Task<List<ProductViewModel>> GetProductsForHomePageAsync(int count);
        Task<List<ProductViewModel>> GetAllProductsBySearchTerm(int page, int pageSize, string searchTerm);

    }
}
