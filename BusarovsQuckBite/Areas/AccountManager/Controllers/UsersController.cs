using BusarovsQuckBite.Areas.AccountManager.Controllers;
using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Text.Encodings.Web;
namespace BusarovsQuckBite.Areas.Users.Controllers
{
    public class UsersController : BaseAreaController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
        private readonly ApplicationSignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly ILogger<ApplicationUser> _logger;
        private readonly IEmailSender _emailSender;
        public UsersController(ApplicationUserManager<ApplicationUser> userManager,
            ApplicationSignInManager<ApplicationUser> signInManager,
            ILogger<ApplicationUser> logger,
           RoleManager<ApplicationRole> roleManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = new ApplicationUser()
                {
                    UserName = model.Username,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    TransactionDateAndTime = DateTime.Now,
                    IsActive = true
                };
                var result = await _userManager.CreateAsync(entity, model.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    if (await _roleManager.RoleExistsAsync(RoleConstants.CustomerRoleName))
                    {
                        await _userManager.AddToRoleAsync(entity, RoleConstants.CustomerRoleName);
                    }
                    var token = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(await _userManager.GenerateEmailConfirmationTokenAsync(entity)));
                    string callbackUrl = Url.Action("ConfirmEmail", "Manage", new { area = "AccountManager", userId = entity.Id, token = token  }, Request.Scheme)!;
                    await _emailSender.SendEmailAsync(entity.Email, $"Confirm your email - QuickBite - {entity.UserName}",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>  to access <b>all features and discounts.</b>");
                    TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyAdded, "Account") + Environment.NewLine + "Email Verification sent! Please verify email to access all features!";
                    return RedirectToAction(nameof(Login));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }
            return View(model);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null)
            {
                var hasRequiredRights = await _signInManager.CanSignInAsync(user);
                if (hasRequiredRights)
                {
                    if (ModelState.IsValid)
                    {
                        var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: true);
                        if (result.Succeeded)
                        {
                            _logger.LogInformation($"User with id {user.Id} logged in.");
                            return RedirectToAction("Index", "Home", new { area = "" });

                        }
                        if (result.IsLockedOut)
                        {
                            _logger.LogWarning($"User account with id {user.Id} is locked out.");
                            ModelState.AddModelError(nameof(model.Password), "Account is Locked! Please try again later.");
                            return View(model);
                        }
                        ModelState.AddModelError(nameof(model.Password), "Invalid username or password.");
                        return View(model);
                    }
                }
            }
            ModelState.AddModelError(nameof(model.Password), "Invalid login attempt.");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
