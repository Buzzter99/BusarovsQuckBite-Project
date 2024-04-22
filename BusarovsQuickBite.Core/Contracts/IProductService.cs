using BusarovsQuickBite.Core.Models.Enums;
using BusarovsQuickBite.Core.Models.Product;
using BusarovsQuickBite.Infrastructure.Data.Models;

namespace BusarovsQuickBite.Core.Contracts
{
    public interface IProductService
    {
        Task<ProductAllViewModel> GetAllProductsAsync(string? category,FilterEnum filter);
        Task AddProduct(ProductFormViewModel model, string userId);
        Task DeleteProduct(int id);
        Task<Product> GetProductByIdAsync(int productId);
        Task<ProductFormViewModel> MapProductAsync(int id);
        Task EditProductAsync(ProductFormViewModel model);
        Task<List<ProductViewModel>> GetProductsForHomePageAsync(int count);
        Task<List<ProductViewModel>> GetAllProductsBySearchTerm(string searchTerm);
        Task<List<ProductViewModel>> GetProductsForOrderAsync(int orderId);

    }
}
