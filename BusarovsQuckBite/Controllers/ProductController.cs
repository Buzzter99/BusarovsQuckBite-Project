﻿using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
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
        public async Task<IActionResult> All(string category, int page = 1, int pageSize = 5, FilterEnum statusFilter = FilterEnum.All)
        {
            var model = await _productService.GetAllProductsAsync(pageSize, page, category,statusFilter);
            if (!HttpContext.Request.GetDisplayUrl().Contains(nameof(pageSize)))
            {
                page = 1;
            }
            if (model.Item2 == 0)
            {
                model.Item2++;
            }
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = model.Item2;
            ViewBag.PageSize = pageSize;
            ViewBag.Category = category;
            ViewBag.Filter = statusFilter;
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
