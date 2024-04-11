using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Category;
using BusarovsQuckBite.Models.Enums;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

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
            TempData["keyword"] = keyword;
            var models = _categoryService.GetAllCategoriesForView(await _categoryService.GetCategoriesForUserByStatusAsync(keyword));
            return View(models);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int categoryId, string currentTab)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(categoryId);
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction(nameof(All));
            }
            return RedirectToAction(nameof(All), "Category", new { keyword = currentTab.Split(" ")[0] });
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _categoryService.AddCategoryAsync(model, User.Identity.GetUserId());
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyAdded,nameof(Category));
            ModelState.Clear();
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            CategoryViewModel model;
            try
            {
                model = await _categoryService.GetCategoryMappedByIdAsync(id);
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return View();
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _categoryService.EditCategoryAsync(model);
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return View();
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyModified);
            return View(model);
        }
        public async Task<IActionResult> Search(FilterEnum keyword, string? name)
        {
            name = name ?? "";
            var items = _categoryService.GetAllCategoriesForView(await _categoryService.SearchByNameAsync(keyword, name));
            TempData["keyword"] = keyword;
            return View(nameof(All), items);
        }
        public async Task<IActionResult> ClearFilter(FilterEnum keyword)
        {
            var items = _categoryService.GetAllCategoriesForView(await _categoryService.GetCategoriesForUserByStatusAsync(keyword));
            TempData["keyword"] = keyword;
            return View(nameof(All), items);
        }
    }
}
