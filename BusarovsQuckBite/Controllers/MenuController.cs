using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
