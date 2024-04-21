using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Address;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
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
            var myAddresses = await _addressService.GetAddressesForUserAsync(User.Identity.GetUserId());
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
                await _addressService.AddAddress(model, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                ModelState.AddModelError(string.Empty, ae.Message);
                return View(model);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode(string.Format(SuccessMessageConstants.SuccessfullyAdded, nameof(Address)));
            ModelState.Clear();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeactivateAddress(int addressId)
        {
            try
            {
                await _addressService.DeleteAddress(addressId, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(All));
            }
            return RedirectToAction(nameof(All));
        }
        public async Task<IActionResult> EditAddress(int addressId)
        {
            AddressViewModel address;
            try
            {
                address = await _addressService.GetByIdForUser(addressId,User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(All));
            }
            return View(address);
        }
        [HttpPost]
        public async Task<IActionResult> EditAddress(AddressViewModel address)
        {
            try
            {
                await _addressService.GetByIdForUser(address.AddressId, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(All));
            }
            if (!ModelState.IsValid)
            {
                return View(address);
            }
            try
            {
                await _addressService.EditAddress(address, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                ModelState.AddModelError(string.Empty, ae.Message);
                return View(address);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode(string.Format(SuccessMessageConstants.SuccessfullyModified));
            return View(address);
        }
    }
}
