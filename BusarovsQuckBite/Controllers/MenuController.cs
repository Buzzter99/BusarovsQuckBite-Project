using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.PageHelpers;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    public class MenuController : Controller
    {
        private readonly IProductService _productService;
        public MenuController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> All(int page = 1, string searchTerm = "")
        {
            int pageSize = 3;
            ViewBag.Search = searchTerm;
            var entities = await _productService.GetAllProductsBySearchTerm(searchTerm);
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize,entities) == 0 ? 1 : PageHelper.CalculateTotalPages(pageSize, entities);
            if (ViewBag.TotalPages < page || page <= 0)
            {
                page = 1;
                ViewBag.PageNumber = page;
            }
            ViewBag.PageSize = pageSize;
            return View(PageHelper.CalculateItemsForPage(page,pageSize,entities));
        }
        public async Task<IActionResult> Search(string? name)
        {
            var products = await _productService.GetAllProductsBySearchTerm(name ?? "");
            return RedirectToAction(nameof(All), new { page = 1, searchTerm = products.Any() ? name : "" });
        }
        public IActionResult ClearFilter()
        {
            return RedirectToAction(nameof(All),new {page = 1});
        }
    }
}
