using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllProductsAsync();
    }
}
