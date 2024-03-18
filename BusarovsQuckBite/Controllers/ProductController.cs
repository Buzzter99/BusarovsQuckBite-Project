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
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> All(string category, int page = 1, int pageSize = 5)
        {
            var model = await _productService.GetAllProductsAsync(pageSize, page, category);
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = model.Item2;
            ViewBag.PageSize = pageSize;
            return View(model.Item1);
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
                await _productService.AddProduct(model,GetUserId());
            }
            catch (InvalidOperationException ioe)
            {
                ModelState.AddModelError(string.Empty,ioe.Message);
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
    }
}
