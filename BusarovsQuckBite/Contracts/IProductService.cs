using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IProductService
    {
        Task<(List<ProductViewModel>,int)> GetAllProductsAsync(int pageSize, int page, string? category);
        Task AddProduct(ProductFormViewModel model, string userId);
    }
}
