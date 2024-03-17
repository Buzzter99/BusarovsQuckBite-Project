using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    public class ProductController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
