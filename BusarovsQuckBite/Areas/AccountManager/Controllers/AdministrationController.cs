using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Enums;
using BusarovsQuckBite.Models.PageHelpers;
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
        private readonly RoleManager<ApplicationRole> _roleManager;

        public AdministrationController(ApplicationUserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index(FilterEnum keyword = FilterEnum.All, int page = 1)
        {
            int pageSize = 10;
            var model = await _userManager.GetAllUsersByStatusAsync(keyword, pageSize, page);
            page = Math.Max(1, Math.Min(page, PageHelper.CalculateTotalPages(pageSize, model.AdministrationDataModel)));
            ViewBag.Keyword = keyword;
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize, model.AdministrationDataModel);
            ViewBag.PageSize = pageSize;
            model.AdministrationDataModel = PageHelper.CalculateItemsForPage(page,pageSize,model.AdministrationDataModel);
            return View(model);
        }

        public IActionResult Edit(AdministrationViewModel model)
        {
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, AdministrationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Edit), model);
            }
            var entity = await _userManager.FindByIdAsync(id);
            if (entity == null)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ErrorMessagesConstants.EntityNotFoundExceptionMessage;
                return View(nameof(Edit), model);
            }
            var user = _userManager.EditRequiredUserData(entity, model);
            var operation = await _userManager.UpdateAsync(user);
            if (!operation.Succeeded)
            {
                foreach (var error in operation.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = SuccessMessageConstants.SuccessfullyModified;
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ManageRoles(string id, FilterEnum keyword)
        {
            var entity = await _userManager.FindByIdAsync(id);
            if (entity == null)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ErrorMessagesConstants.EntityNotFoundExceptionMessage;
                return RedirectToAction(nameof(Index), new { keyword = keyword });
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
                TempData[ErrorMessagesConstants.FailedMessageKey] = string.Join(Environment.NewLine, result.Errors.Select(c => c.Description));
                return View(nameof(ManageRoles), await _userManager.MapViewModel(entity));
            }
            return BadRequest();
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
                TempData[ErrorMessagesConstants.FailedMessageKey] = string.Join(Environment.NewLine, result.Errors.Select(c => c.Description));
                return View(nameof(ManageRoles), await _userManager.MapViewModel(entity));
            }
            return BadRequest();
        }
        public async Task<IActionResult> ManageAccess(string id, FilterEnum keyword, int currentPage)
        {
            var model = await _userManager.FindByIdAsync(id);
            if (model == null)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ErrorMessagesConstants.EntityNotFoundExceptionMessage;
                return RedirectToAction(nameof(Index), new { keyword = keyword, page = currentPage });
            }
            model.IsActive = !model.IsActive;
            await _userManager.UpdateAsync(model);
            return RedirectToAction(nameof(Index), new { keyword = keyword, page = currentPage});
        }

        public async Task<IActionResult> ChangePassword(string id, FilterEnum keyword)
        {
            var entity = await _userManager.FindByIdAsync(id);
            if (entity == null)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ErrorMessagesConstants.EntityNotFoundExceptionMessage;
                return RedirectToAction(nameof(Index), new { keyword = keyword });
            }
            return View(_userManager.MapPasswordViewModel(entity));
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
                TempData[ErrorMessagesConstants.FailedMessageKey] = ErrorMessagesConstants.EntityNotFoundExceptionMessage;
                return View(model);
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(entity);
            var result = await _userManager.ResetPasswordAsync(entity, token, model.Password);
            if (result.Succeeded)
            {
                TempData[SuccessMessageConstants.SuccessMessageKey] = SuccessMessageConstants.SuccessfullyModified;
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
