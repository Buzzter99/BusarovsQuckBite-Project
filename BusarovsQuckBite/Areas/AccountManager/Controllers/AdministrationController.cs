using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Protocol.Core.Types;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    [Authorize(Roles = RoleConstants.AdminRoleName)]
    public class AdministrationController : BaseController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;

        public AdministrationController(ApplicationUserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _userManager.GetAllUsers();
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            return View();
        }

    }
}
