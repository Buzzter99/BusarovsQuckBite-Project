using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
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
        [HttpPost]
        public async Task<IActionResult> Delete(int categoryId, string currentTab)
        {
            try
            {
                await _categoryService.DeleteCategoryAsync(categoryId);
            }
            catch (InvalidOperationException ioe) when (ioe.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage))
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ioe.Message;
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
            await _categoryService.AddCategoryAsync(model, GetUserId());
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
            catch (InvalidOperationException ioe) when(ioe.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage))
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ioe.Message;
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
            catch (InvalidOperationException ioe) when (ioe.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage))
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ioe.Message;
                return View();
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyModified);
            return View(model);
        }
        public async Task<IActionResult> Search(string keyword, string? name)
        {
            name = name ?? "";
            if (Enum.TryParse(keyword.Split(" ")[0], out FilterEnum parsedEnum))
            {
                var items = await _categoryService.SearchByNameAsync(parsedEnum, name);
                TempData["keyword"] = keyword.Split(" ")[0] + " " + "Categories";
                return View(nameof(All), items);
            }
            TempData[ErrorMessagesConstants.FailedMessageKey] = string.Format(ErrorMessagesConstants.GeneralErrorMessage);
            return RedirectToAction(nameof(All));
        }

        public async Task<IActionResult> ClearFilter(string keyword)
        {
            if (Enum.TryParse(keyword.Split(" ")[0], out FilterEnum parsedEnum))
            {
                var items = await _categoryService.GetCategoriesForUserByStatusAsync(parsedEnum);
                TempData["keyword"] = keyword.Split(" ")[0] + " " + "Categories";
                return View(nameof(All), items);
            }
            TempData[ErrorMessagesConstants.FailedMessageKey] = string.Format(ErrorMessagesConstants.GeneralErrorMessage);
            return RedirectToAction(nameof(All));
        }
    }
}
