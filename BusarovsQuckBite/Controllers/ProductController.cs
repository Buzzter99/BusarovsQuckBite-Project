using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Enums;
using BusarovsQuckBite.Models.PageHelpers;
using BusarovsQuckBite.Models.Product;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Controllers
{
    [Authorize(Roles = RoleConstants.AdminRoleName)]
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> All(string category, int page = 1, FilterEnum statusFilter = FilterEnum.All)
        {
            int pageSize = 5;
            var model = await _productService.GetAllProductsAsync(category,statusFilter);
            int size = PageHelper.CalculateTotalPages(pageSize, model.Products) == 0 ? 1 : PageHelper.CalculateTotalPages(pageSize, model.Products);
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = size;
            ViewBag.PageSize = pageSize;
            ViewBag.Category = category;
            ViewBag.Filter = statusFilter;
            if (ViewBag.TotalPages < page || page <= 0)
            {
                page = 1;
                ViewBag.PageNumber = page;
            }
            model.Products = PageHelper.CalculateItemsForPage(page, pageSize, model.Products);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductFormViewModel model)
        {
            model.ActiveCategories = await _categoryService.GetCategoriesForUserByStatusAsync(FilterEnum.Active);
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _productService.AddProduct(model,User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                ModelState.AddModelError(string.Empty,ae.Message);
                return View(model);
            }
            ModelState.Clear();
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyAdded,nameof(Product));
            return View(new ProductFormViewModel()
            {
                ActiveCategories = model.ActiveCategories
            });
        }
        public async Task<IActionResult> Add()
        {
            var model = new ProductFormViewModel()
            {
                ActiveCategories = await _categoryService.GetCategoriesForUserByStatusAsync(FilterEnum.Active)
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id, string category, int page,FilterEnum statusFilter)
        {
            try
            {
                await _productService.DeleteProduct(id);
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction(nameof(All), new { category = category, page = page });
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = SuccessMessageConstants.SuccessfullyModified;
            return RedirectToAction(nameof(All), new { category = category, page = page,statusFilter = statusFilter });
        }
        public async Task<IActionResult> Edit(int id)
        {
            ProductFormViewModel model;
            try
            {
               model = await _productService.MapProductAsync(id);
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction(nameof(All));
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductFormViewModel model)
        {
            model.ActiveCategories = await _categoryService.GetCategoriesForUserByStatusAsync(FilterEnum.Active);
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _productService.EditProductAsync(model);
            }
            catch (ApplicationException ae)
            {
                ModelState.AddModelError(string.Empty,ae.Message);
                return View(model);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyModified);
            return View(model);
        }
    }
}
