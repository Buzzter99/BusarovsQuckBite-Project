using BusarovsQuickBite.Core.Models.Category;
using BusarovsQuickBite.Core.Models.Enums;
using BusarovsQuickBite.Infrastructure.Data.Models;

namespace BusarovsQuickBite.Core.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(FilterEnum keyword);
        Task DeleteCategoryAsync(int id);
        Task AddCategoryAsync(CategoryViewModel model,string creatorId);
        Task<CategoryViewModel> GetCategoryMappedByIdAsync(int id);
        Task<CategoryViewModel> EditCategoryAsync(CategoryViewModel model);
        Task<List<CategoryViewModel>> SearchByNameAsync(FilterEnum keyword, string name);
        Task<Category> GetByIdAsync(int id);
        CategoryAllViewModel GetAllCategoriesForView(List<CategoryViewModel> model);
    }
}
