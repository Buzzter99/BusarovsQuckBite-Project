using BusarovsQuckBite.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    [Authorize(Roles = RoleConstants.AdminRoleName)]
    public class CategoryController : BaseController
    {
        public IActionResult All()
        {
            return View();
        }
    }
}
