using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    public class ManageController : BaseAreaController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
