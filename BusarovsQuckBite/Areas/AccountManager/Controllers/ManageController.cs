using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    public class ManageController : BaseAreaController
    {
        private ApplicationUserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        public ManageController(ApplicationUserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _emailSender = emailSender;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult ResendEmailConfirmation()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ResendEmailConfirmation(ResendEmailConfirmationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                string callbackUrl = Url.Action("ConfirmEmail", "Manage", new { area = "AccountManager", userId = user.Id, token = token }, Request.Scheme)!;
                await _emailSender.SendEmailAsync(user.Email, $"Confirm your email - QuickBite - {user.UserName}",
                    $"Please confirm your account by <a href='{callbackUrl}'>clicking here</a>  to access <b>all features and discounts.</b>");
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = "Email Verification sent!";
            return RedirectToAction(nameof(ResendEmailConfirmation));
        }
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmailAsync(string? userId, string? token)
        {
            ViewBag.Message = "Email Confirmed Successfully!";
            if (userId != null && token != null)
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    if (user.EmailConfirmed)
                    {
                        ViewBag.Message = "Email Already Confirmed!";
                        return View();
                    }
                    var result = await _userManager.ConfirmEmailAsync(user, token);
                    if (result.Succeeded)
                    {
                        return View();
                    }
                    foreach (var error in result.Errors)
                    {
                        string value = error.Description;
                        ViewBag.Message = value;
                    }
                }
            }
            return View();
        }
    }
}
