using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BusarovsQuckBite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var entities = await _productService.GetProductsForHomePageAsync();
            return View(entities);
        }
        public IActionResult BadRequestView()
        {
            return View();
        }
        public IActionResult InvalidOperation()
        {
            return View();
        }
        public IActionResult NotFoundView()
        {
            return View();
        }
        public IActionResult InternalServerError()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
