using BusarovsQuckBite.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> All()
        {
            var model = await _productService.GetAllProductsAsync();
            return View(model);
        }
    }
}
