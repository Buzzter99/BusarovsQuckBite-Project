using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Models.PageHelpers;
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
            var entities = await _productService.GetAllProductsBySearchTerm(page,pageSize,searchTerm);
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize,entities);
            ViewBag.PageSize = pageSize;
            return View(PageHelper.CalculateItemsForPage(page,pageSize,entities));
        }
        public async Task<IActionResult> Search(string? name)
        {
            var products = await _productService.GetAllProductsBySearchTerm(1, 3,name ?? "");
            return RedirectToAction(nameof(All), new { page = 1, searchTerm = name });
        }
        public IActionResult ClearFilter()
        {
            return RedirectToAction(nameof(All),new {page = 1});
        }
    }
}
