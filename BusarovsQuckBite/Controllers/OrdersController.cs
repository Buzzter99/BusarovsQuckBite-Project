using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Controllers
{
    public class OrdersController : BaseController
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public OrdersController(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }
        [HttpPost]
        public async Task<IActionResult> MyOrder(CartViewModel model)
        {
            OrderViewModel orderView = new OrderViewModel();
            try
            {
                orderView = await _orderService.ValidateOrderAsync(model, GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction("MyCart", "Cart");
            }
            return View(orderView);
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(OrderViewModel model)
        {
            try
            {
                model = await _orderService.ValidateOrderAsync(model.Cart, GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction("MyCart", "Cart");
            }
            if (!ModelState.IsValid)
            {
                return View(nameof(MyOrder), model);
            }
            else
            {
                //place order
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
