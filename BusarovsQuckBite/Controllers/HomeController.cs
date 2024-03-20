using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;

namespace BusarovsQuckBite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, IProductService productService, ApplicationDbContext context)
        {
            _logger = logger;
            _productService = productService;
            _context = context;
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
