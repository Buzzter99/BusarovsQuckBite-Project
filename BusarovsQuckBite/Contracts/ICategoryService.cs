using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;

namespace BusarovsQuckBite.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(FilterEnum keyword);
        Task DeleteCategoryAsync(int id);
        Task AddCategoryAsync(CategoryViewModel model,string creatorId);
        Task<CategoryViewModel> GetCategoryMappedByIdAsync(int id);
        Task<CategoryViewModel> EditCategoryAsync(CategoryViewModel model);
        Task<List<CategoryViewModel>> SearchByNameAsync(FilterEnum keyword, string name);
    }
}
