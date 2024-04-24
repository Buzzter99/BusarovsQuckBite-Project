using BusarovsQuickBite.Core.Services;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;
using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.Enums;
using BusarovsQuickBite.Core.Models.Manage;

namespace BusarovsQuckBite.Areas.AccountManager.Controllers
{
    public class ManageController : BaseAreaController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IDataProtectionService _protectionService;
        public ManageController(ApplicationUserManager<ApplicationUser> userManager, 
            IEmailSender emailSender, 
            IDataProtectionService protectionService)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _protectionService = protectionService;
        }
        public async Task<IActionResult> Index()
        {
            var userData = _userManager.MapInfoForUser(await _userManager.FindByIdAsync(User.Identity.GetUserId()));
            return View(new UserAllInfoViewModel { UpdateUserDataViewModel = userData,ActiveTab = TabEnum.Profile.ToString()});
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
                    TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode("Password Changed Successfully");
                    return View();
                }
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(string.Join(Environment.NewLine, result.Errors.Select(c => c.Description)));
                return View(model);
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
                await _emailSender.SendEmailAsync(user.Email, $"Password Reset",
                    $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>",UserConstants.AdminEmail);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode("Reset Password link sent. Please check your email");
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
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(await _userManager.GenerateEmailConfirmationTokenAsync(user)));
                string callbackUrl = Url.Action("ConfirmEmail", "Manage", new { area = "AccountManager", userId = user.Id, token = token }, Request.Scheme)!;
                await _emailSender.SendEmailAsync(user.Email, $"Confirm your email - QuickBite",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>  to access <b>all features and discounts.</b>", UserConstants.AdminEmail);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode("Email Verification sent!");
            return RedirectToAction(nameof(ResendEmailConfirmation));
        }
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmailAsync(string? userId, string? token)
        {
            ViewBag.Message = HtmlEncoder.Default.Encode("Email Confirmed Successfully!");
            if (userId != null && token != null)
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    if (user.EmailConfirmed)
                    {
                        ViewBag.Message = HtmlEncoder.Default.Encode("Email Already Confirmed!");
                        return View();
                    }
                    var result = await _userManager.ConfirmEmailAsync(user, Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(token)));
                    if (result.Succeeded)
                    {
                        await _userManager.UpdateSecurityStampAsync(user);
                        return View();
                    }
                    ViewBag.Message = HtmlEncoder.Default.Encode(string.Join(Environment.NewLine, result.Errors.Select(c => c.Description)));
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUserData(UpdateUserDataViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), new UserAllInfoViewModel { UpdateUserDataViewModel = model,ActiveTab = TabEnum.Profile.ToString()});
            }
            var user = await _userManager.FindByIdAsync(User.Identity.GetUserId());
            if (user != null)
            {
                if (model.FirstName != null && !string.IsNullOrEmpty(model.FirstName) && !string.IsNullOrWhiteSpace(model.FirstName))
                {
                    user.FirstName = _protectionService.Encrypt(model.FirstName);
                }
                if (model.LastName != null && !string.IsNullOrEmpty(model.FirstName) && !string.IsNullOrWhiteSpace(model.FirstName))
                {
                    user.LastName = _protectionService.Encrypt(model.LastName);
                }
                user.PhoneNumber = model.PhoneNumber;
                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(nameof(model.Email),error.Description);
                    }
                    return View(nameof(Index), new UserAllInfoViewModel { UpdateUserDataViewModel = model, ActiveTab = TabEnum.Profile.ToString()});
                }
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode(SuccessMessageConstants.SuccessfullyModified);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ChangePassword(ChangeUserPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Index), new UserAllInfoViewModel { ActiveTab = TabEnum.ChangePassword.ToString(),UpdateUserDataViewModel = _userManager.MapInfoForUser(await _userManager.FindByIdAsync(User.Identity.GetUserId())),ChangeUserPasswordViewModel = model});
            }
            var changePassword = await _userManager.ChangePasswordAsync(await _userManager.FindByIdAsync(User.Identity.GetUserId()),model.OldPassword,model.Password);
            if (!changePassword.Succeeded)
            {
                foreach (var error in changePassword.Errors)
                {
                    ModelState.AddModelError(nameof(model.ConfirmPassword), error.Description);
                }
                return View(nameof(Index), new UserAllInfoViewModel { ActiveTab = TabEnum.ChangePassword.ToString(), UpdateUserDataViewModel = _userManager.MapInfoForUser(await _userManager.FindByIdAsync(User.Identity.GetUserId())), ChangeUserPasswordViewModel = model });
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = "Password Changed Successfully";
            return View(nameof(Index), new UserAllInfoViewModel { ActiveTab = TabEnum.ChangePassword.ToString(), UpdateUserDataViewModel = _userManager.MapInfoForUser(await _userManager.FindByIdAsync(User.Identity.GetUserId())) });

        }
        [AllowAnonymous]
        public IActionResult ResetUsername()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetUsername(ResendEmailConfirmationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(await _userManager.GenerateUserTokenAsync(user,"Default","ResetUsername")));
                string callbackUrl = Url.Action("ResetUsernameConfirmation", "Manage", new { area = "AccountManager", token = token }, Request.Scheme)!;
                await _emailSender.SendEmailAsync(user.Email, $"Reset Your Username - QuickBite",
                    $"Please reset your username by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>", UserConstants.AdminEmail);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode("Username Reset Link Sent");
            return RedirectToAction(nameof(ResetUsername));
        }
        [AllowAnonymous]
        public IActionResult ResetUsernameConfirmation(string? token)
        {
            ResetUsernameViewModel model = new ResetUsernameViewModel();
            if (token != null)
            {
                model.Token = token;
            }
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetUsernameConfirmation(ResetUsernameViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _userManager.VerifyUserTokenAsync(user,"Default","ResetUsername", Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(model.Token)));
                if (!result)
                {
                    TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode("An error occured. Please try again Later!");
                    return View(model);
                }
                user.UserName = model.NewUsername;
                var operation = await _userManager.UpdateAsync(user);
                if (!operation.Succeeded)
                {
                    foreach (var error in operation.Errors)
                    {
                        ModelState.AddModelError(string.Empty,error.Description);
                    }
                    return View(model);
                }
                await _userManager.UpdateSecurityStampAsync(user);
                TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode("Username Changed Successfully");
                return View();
            }
            return View();
        }
    }
}
