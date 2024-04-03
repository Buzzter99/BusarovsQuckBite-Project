using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    public class ManageController : BaseAreaController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
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
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPasswordConfirmation(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(model.Token)), model.Password);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    TempData[SuccessMessageConstants.SuccessMessageKey] = "Password Changed Successfully";
                    return View();
                }
                TempData[ErrorMessagesConstants.FailedMessageKey] = string.Join(Environment.NewLine, result.Errors.Select(c => c.Description));
            }
            return View();
        }
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation(string? token)
        {
            ForgotPasswordViewModel model = new ForgotPasswordViewModel();
            if (token != null)
            {
                model.Token = token;
            }
            else
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ErrorMessagesConstants.GeneralErrorMessage;
            }
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ResendEmailConfirmationViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null && !user.EmailConfirmed)
            {
                ModelState.AddModelError(nameof(model.Email), "Email not confirmed yet!");
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (user != null)
            {

                var token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(await _userManager.GeneratePasswordResetTokenAsync(user))); 
                string callbackUrl = Url.Action("ForgotPasswordConfirmation", "Manage", new { area = "AccountManager", token = token }, Request.Scheme)!;
                await _emailSender.SendEmailAsync(user.Email, $"Password Reset - {user.UserName}",
                    $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>");
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = "Reset Password link sent. Please check your email";
            return RedirectToAction(nameof(ForgotPassword));
        }
        [AllowAnonymous]
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
                var token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(await _userManager.GenerateEmailConfirmationTokenAsync(user)));
                string callbackUrl = Url.Action("ConfirmEmail", "Manage", new { area = "AccountManager", userId = user.Id, token = token }, Request.Scheme)!;
                await _emailSender.SendEmailAsync(user.Email, $"Confirm your email - QuickBite - {user.UserName}",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>  to access <b>all features and discounts.</b>");
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
                    var result = await _userManager.ConfirmEmailAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token)));
                    if (result.Succeeded)
                    {
                        await _userManager.UpdateSecurityStampAsync(user);
                        return View();
                    }
                    ViewBag.Message = string.Join(Environment.NewLine, result.Errors.Select(c => c.Description));
                }
            }
            return View();
        }
    }
}
