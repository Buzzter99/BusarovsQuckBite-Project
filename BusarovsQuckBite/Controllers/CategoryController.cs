using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    [Authorize(Roles = RoleConstants.AdminRoleName)]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> All(FilterEnum keyword = FilterEnum.All)
        {
            TempData["keyword"] = keyword + " " + "Categories";
            var models = await _categoryService.GetCategoriesForUserByStatusAsync(keyword);
            return View(models);
        }
        public async Task<IActionResult> Delete(int categoryId, string currentTab)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(categoryId, GetUserId());
            }
            catch (InvalidOperationException ioe) when (ioe.Message.Contains(ErrorMessagesConstants.OwnerIsInvalid) || ioe.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage))
            {
                TempData["Failed"] = ioe.Message;
                return RedirectToAction(nameof(All));
            }
            return RedirectToAction(nameof(All), "Category", new { keyword = currentTab.Split(" ")[0] });
        }
    }
}
