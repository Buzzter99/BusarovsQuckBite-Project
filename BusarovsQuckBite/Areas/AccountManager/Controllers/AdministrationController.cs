using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet]
        public async Task<IActionResult> Index(string keyword = "All")
        {
            List<AdministrationViewModel> model;
            ViewBag.Keyword = keyword;
            switch (keyword)
            {
                case "All":
                    model = await _userManager.GetAllUsers();
                    break;
                case "Active":
                    model = await _userManager.GetAllActiveUsersAsync(); 
                    break;
                case "Deactivated":
                    model = await _userManager.GetAllDeactivatedUsersAsync();
                    break;
                default: model = await _userManager.GetAllUsers();
                    ViewBag.Keyword = "All";
                    break;
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ManageRoles(string id)
        {
            var entity = await _userManager.FindByIdAsync(id);
            if (entity != null)
            {
                var model = await _userManager.MapViewModel(entity);
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> AddToRoleAsync(string userId, string roleName)
        {
            var entity = await _userManager.FindByIdAsync(userId);
            if (entity != null)
            {
                var result = await _userManager.AddToRoleAsync(entity, roleName);
                if (result.Succeeded)
                {
                    return View(nameof(ManageRoles), await _userManager.MapViewModel(entity));
                }
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromRoleAsync(string userId, string roleName)
        {
            var entity = await _userManager.FindByIdAsync(userId);
            if (entity != null)
            {
                var result = await _userManager.RemoveFromRoleAsync(entity, roleName);
                if (result.Succeeded)
                {
                    return View(nameof(ManageRoles), await _userManager.MapViewModel(entity));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ManageAccess(string id)
        {
            var model = await _userManager.FindByIdAsync(id);
            if (model != null)
            {
                model.IsActive = !model.IsActive;
                await _userManager.UpdateAsync(model);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
