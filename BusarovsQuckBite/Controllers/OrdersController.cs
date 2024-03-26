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

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public async Task<IActionResult> MyOrder(CartViewModel model)
        {
            OrderViewModel orderView = new OrderViewModel()
            {
                Cart = model
            };
            try
            {
                orderView = await _orderService.ValidateOrderAsync(orderView, GetUserId());
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
                model = await _orderService.ValidateOrderAsync(model, GetUserId());
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
            await _orderService.PlaceOrder(model, GetUserId());
            return RedirectToAction(nameof(Orders));
        }
        public async Task<IActionResult> Orders(CartViewModel model)
        {
            return View();
        }
    }
}
