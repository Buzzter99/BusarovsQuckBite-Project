using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    [Authorize(Roles = RoleConstants.AdminRoleName)]
    public class AdministrationController : BaseAreaController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
        private readonly IDataProtectionService _dataProtectionService;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AdministrationController(ApplicationUserManager<ApplicationUser> userManager,
            IDataProtectionService protectionService,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _dataProtectionService = protectionService;
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index(string keyword = "All", int page = 1, int pageSize = 10)
        {
            List<AdministrationViewModel> model = await _userManager.GetAllUsersByStatusAsync(keyword, pageSize, page);
            ViewBag.Keyword = keyword;
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = await _userManager.CalculateTotalPages(pageSize);
            ViewBag.PageSize = pageSize;
            return View(model);
        }

        public IActionResult Edit(AdministrationViewModel model)
        {
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id,AdministrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Edit), model);
            }
            var entity = await _userManager.FindByIdAsync(id);
            if (entity == null)
            {
                return BadRequest();
            }
            entity.Email = model.Email.Trim();
            entity.FirstName = model.FirstName == null ? "": _dataProtectionService.Encrypt(model.FirstName!);
            entity.LastName = model.LastName == null ? "" : _dataProtectionService.Encrypt(model.LastName!);
            entity.PhoneNumber = model.PhoneNumber.Trim();
            entity.UserName = model.Username.Trim();
            var operation = await _userManager.UpdateAsync(entity);
            if (!operation.Succeeded)
            {
                foreach (var error in operation.Errors)
                {
                    ModelState.AddModelError(string.Empty,error.Description);
                }
                return View(model);
            }
            TempData["Success"] = SuccessMessageConstants.SuccessfullyModified;
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ManageRoles(string id)
        {
            var entity = await _userManager.FindByIdAsync(id);
            if (entity == null)
            {
                return BadRequest();
            }
            var model = await _userManager.MapViewModel(entity);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddToRoleAsync(string userId, string roleName)
        {
            var entity = await _userManager.FindByIdAsync(userId);
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (entity != null && roleExists)
            {
                var result = await _userManager.AddToRoleAsync(entity, roleName);
                if (result.Succeeded)
                {
                    return View(nameof(ManageRoles), await _userManager.MapViewModel(entity));
                }
            }
            else
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(ManageRoles), await _userManager.MapViewModel(entity));
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromRoleAsync(string userId, string roleName)
        {
            var entity = await _userManager.FindByIdAsync(userId);
            var roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (entity != null && roleExists)
            {
                var result = await _userManager.RemoveFromRoleAsync(entity, roleName);
                if (result.Succeeded)
                {
                    return View(nameof(ManageRoles), await _userManager.MapViewModel(entity));
                }
            }
            else
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(ManageRoles), await _userManager.MapViewModel(entity));
        }

        public async Task<IActionResult> ManageAccess(string id, string keyword)
        {
            var model = await _userManager.FindByIdAsync(id);
            if (model == null)
            {
                return BadRequest();
            }
            model.IsActive = !model.IsActive;
            await _userManager.UpdateAsync(model);
            return RedirectToAction(nameof(Index),"Administration", new { keyword = $"{keyword}"});
        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            var entity = await _userManager.FindByIdAsync(id);
            if (entity == null)
            {
                return BadRequest();
            }
            return View(new ChangePasswordViewModel()
            {
                Id = entity.Id,
                Username = entity.UserName
            });
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var entity = await _userManager.FindByIdAsync(model.Id);
            if (entity == null)
            {
                return BadRequest();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(entity);
            var result = await _userManager.ResetPasswordAsync(entity, token, model.Password);
            if (result.Succeeded)
            {
                TempData["Success"] = SuccessMessageConstants.SuccessfullyModified;
                return View(model);
            }
            foreach (var kvp in result.Errors)
            {
                ModelState.AddModelError(string.Empty, kvp.Description);
            }
            return View(model);
        }
    }
}
