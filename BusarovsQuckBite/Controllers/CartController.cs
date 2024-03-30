using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Controllers
{
    [Authorize]
    public class CartController : BaseController
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ICartService _cartService;
        public CartController(IHttpContextAccessor contextAccessor, ICartService cartService)
        {
            _contextAccessor = contextAccessor;
            _cartService = cartService;
        }
        public async Task<IActionResult> MyCart()
        {
            var cart = await _cartService.GetCart(GetUserId());
            return View(cart);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId)
        {
            string callbackUrl = _contextAccessor.HttpContext!.Request.Headers["Referer"];
            try
            {
                await _cartService.AddCartProduct(productId,GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return Redirect(callbackUrl);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = string.Format(SuccessMessageConstants.SuccessfullyAdded,nameof(Product));
            return Redirect(callbackUrl);
        }
        public async Task<IActionResult> RemoveItemFromCart(int productId)
        {
            try
            {
               await _cartService.RemoveProductFromCart(productId, GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction(nameof(MyCart));
            }
            return RedirectToAction(nameof(MyCart));
        }
    }
}
