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
            catch (InvalidOperationException e) when (e.Message.Contains(ErrorMessagesConstants.AddressShouldIncludeStreetNumber))
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(model);
            }
            TempData["Success"] = string.Format(SuccessMessageConstants.SuccessfullyAdded, nameof(Address));
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> DeactivateAddress(int addressId)
        {
            try
            {
                await _addressService.DeleteAddress(addressId, GetUserId());
            }
            catch (InvalidOperationException e) when (e.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage) ||
                                                      e.Message.Contains(ErrorMessagesConstants.OwnerIsInvalid))
            {
                TempData["Failed"] = e.Message;
                return RedirectToAction(nameof(All));
            }
            return RedirectToAction(nameof(All));
        }
        public async Task<IActionResult> EditAddress(int addressId)
        {
            AddressViewModel address;
            try
            {
                address = await _addressService.GetByIdForUser(addressId, GetUserId());
            }
            catch (InvalidOperationException e) when (e.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage) ||
                                                      e.Message.Contains(ErrorMessagesConstants.OwnerIsInvalid))
            {
                TempData["Failed"] = e.Message;
                return RedirectToAction(nameof(All));
            }
            return View(address);
        }
        [HttpPost]
        public async Task<IActionResult> EditAddress(AddressViewModel address)
        {
            try
            {
                await _addressService.GetByIdForUser(address.AddressId, GetUserId());
            }
            catch (InvalidOperationException ioe) when (ioe.Message.Contains(ErrorMessagesConstants.EntityNotFoundExceptionMessage) || 
                                                        ioe.Message.Contains(ErrorMessagesConstants.OwnerIsInvalid))
            {
                TempData["Failed"] = ioe.Message;
                return RedirectToAction(nameof(All));
            }
            if (!ModelState.IsValid)
            {
                return View(address);
            }
            try
            {
                await _addressService.EditAddress(address, GetUserId());
            }
            catch (InvalidOperationException e) when (e.Message.Contains(ErrorMessagesConstants.AddressShouldIncludeStreetNumber))
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return View(address);
            }
            TempData["Success"] = string.Format(SuccessMessageConstants.SuccessfullyModified, nameof(Address));
            return View(address);
        }
    }
}
