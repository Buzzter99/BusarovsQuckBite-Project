using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(string? keyword);
        Task DeleteCategoryAsync(int id, string owner);
    }
}
