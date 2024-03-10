using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusarovsQuckBite.Controllers
{
    public class AddressController : BaseController
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
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
                ModelState.AddModelError(string.Empty, ErrorMessagesConstants.AddressShouldIncludeStreetNumber);
                return View(model);
            }
            TempData["Success"] = string.Format(SuccessMessageConstants.SuccessfullyAdded,nameof(Address));
            return View(model);
        }
        public async Task<IActionResult> DeactivateAddress(int addressId)
        {
            try
            {
                await _addressService.DeleteAddress(addressId, GetUserId());
            }
            catch (InvalidOperationException e)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(All));
        }
    }
}
