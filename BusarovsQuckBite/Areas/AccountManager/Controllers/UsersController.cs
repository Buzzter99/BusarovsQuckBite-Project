using BusarovsQuckBite.Areas.AccountManager.Controllers;
using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace BusarovsQuckBite.Areas.Users.Controllers
{
    [Area(AreaConstants.UserArea)]
    public class UsersController : BaseController
    {
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
        private readonly ApplicationSignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<ApplicationUser> _logger;
        public UsersController(ApplicationUserManager<ApplicationUser> userManager, ApplicationSignInManager<ApplicationUser> signInManager, ILogger<ApplicationUser> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
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
            return View();
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return RedirectToAction("Index", "Home", new { area = "" });
                    
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToAction(nameof(Login));
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);

            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
