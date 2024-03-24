using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Enums;
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
        public async Task<IActionResult> All(string searchTerm,int page = 1, int pageSize = 9)
        {
            var entities = await _productService.GetAllProductsAsync(pageSize, page,null, FilterEnum.Active);
            return View(entities.Item1);
        }
        public async Task<IActionResult> Search(string? name)
        {
            var products = await _productService.GetAllProductsBySearchTerm(name ?? "");
            return View(nameof(All),products);
        }
        public async Task<IActionResult> ClearFilter()
        {
            var all = await _productService.GetAllProductsBySearchTerm("");
            return View(nameof(All), all);
        }
    }
}
