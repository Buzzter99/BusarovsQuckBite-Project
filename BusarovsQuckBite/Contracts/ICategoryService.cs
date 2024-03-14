using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;

namespace BusarovsQuckBite.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(FilterEnum keyword);
        Task DeleteCategoryAsync(int id, string owner);
    }
}
