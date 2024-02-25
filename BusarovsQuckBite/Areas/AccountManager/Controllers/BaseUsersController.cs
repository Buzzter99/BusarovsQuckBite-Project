using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    [Authorize]
    public abstract class BaseUsersController : Controller
    {
        public BaseUsersController()
        {
            
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View($"{Constants.Constants.ControllerConstants.BasePathForView}/{nameof(Login)}{Constants.Constants.ControllerConstants.ExtenstionForView}");
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
