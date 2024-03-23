using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

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
            catch (ApplicationException ae)
            {
                ModelState.AddModelError(string.Empty, ae.Message);
                return View(model);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyAdded, nameof(Address));
            ModelState.Clear();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeactivateAddress(int addressId)
        {
            try
            {
                await _addressService.DeleteAddress(addressId, GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
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
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
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
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
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
            catch (ApplicationException ae)
            {
                ModelState.AddModelError(string.Empty, ae.Message);
                return View(address);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyModified, nameof(Address));
            return View(address);
        }
    }
}
