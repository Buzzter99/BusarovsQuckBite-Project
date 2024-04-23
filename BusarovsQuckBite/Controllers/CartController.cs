using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Controllers
{
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
            var cart = await _cartService.GetCart(User.Identity.GetUserId());
            return View(cart);
        }
        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId)
        {
            string callbackUrl = _contextAccessor.HttpContext!.Request.Headers["Referer"];
            try
            {
                await _cartService.AddCartProduct(productId,User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return Redirect(callbackUrl);
            }
            TempData[SuccessMessageConstants.SuccessMessageKey] = HtmlEncoder.Default.Encode(string.Format(SuccessMessageConstants.SuccessfullyAdded,nameof(Product)));
            return Redirect(callbackUrl);
        }
        public async Task<IActionResult> RemoveItemFromCart(int productId)
        {
            try
            {
               await _cartService.RemoveProductFromCart(productId, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(MyCart));
            }
            return RedirectToAction(nameof(MyCart));
        }
    }
}
