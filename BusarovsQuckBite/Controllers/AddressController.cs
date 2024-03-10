using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Controllers
{
    public class AddressController : BaseController
    {
        private readonly IAddressService _addressService;
        private readonly ApplicationUserManager<ApplicationUser> _userManager;
        public AddressController(IAddressService addressService, ApplicationUserManager<ApplicationUser> userManager)
        {
            _addressService = addressService;
            _userManager = userManager;
        }
        public async Task<IActionResult> All()
        {
            var myAddresses = await _addressService.GetAddressesForUserAsync(GetUserId());
            return View(myAddresses);
        }
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAddress(AddressViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                await _addressService.AddAddress(model, GetUserId());
            }
            catch (InvalidOperationException e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(model);
            }
            TempData["Success"] = string.Format(SuccessMessageConstants.SuccessfullyAdded,nameof(Address));
            return View(model);
        }
    }
}
