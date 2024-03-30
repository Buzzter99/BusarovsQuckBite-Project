using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Controllers
{
    [Authorize]
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
            try
            {
                await _orderService.PlaceOrder(model, GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction("MyCart", "Cart");
            }
            return RedirectToAction(nameof(Orders));
        }
        public async Task<IActionResult> Orders()
        {
            var ordersForUser = await _orderService.GetOrdersForUser(GetUserId());
            return View(ordersForUser);
        }
        public async Task<IActionResult> TrackOrder(int id)
        {
            int status;
            try
            {
               status = await _orderService.GetOrderStatus(id, GetUserId());
            }
            catch (ApplicationException ae)
            {
                return RedirectToAction(nameof(Orders));
            }
            return View(status);
        }
        [Authorize(Roles = $"{RoleConstants.AdminRoleName},{RoleConstants.DeliveryDriverRoleName},{RoleConstants.CookingStaffRoleName}")]
        public IActionResult OrderManagement()
        {
            return View();
        }

    }
}
