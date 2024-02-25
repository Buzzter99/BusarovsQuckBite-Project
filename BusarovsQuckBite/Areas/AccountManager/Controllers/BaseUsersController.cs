using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    [Authorize]
    public class BaseUsersController : Controller
    {
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View($"{Constants.Constants.ControllerConstants.BasePathForView}/Login.cshtml");
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
    }
}
