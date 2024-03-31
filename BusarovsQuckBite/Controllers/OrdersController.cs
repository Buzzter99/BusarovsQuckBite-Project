using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.PageHelpers;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> Orders(int page = 1)
        {
            if (page == 0)
            {
                page = 1;
            }
            int pageSize = 10;
            var ordersForUser = await _orderService.GetOrdersForUser(GetUserId());
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize, ordersForUser.OrderModel);
            ViewBag.PageSize = pageSize;
            ordersForUser.OrderModel = (PageHelper.CalculateItemsForPage(page, pageSize, ordersForUser.OrderModel));
            return View(ordersForUser);
        }
        public async Task<IActionResult> TrackOrder(int id)
        {
            int status;
            try
            {
               status = await _orderService.GetOrderStatusAsync(id,GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction(nameof(Orders));
            }
            return View(status);
        }
        [Authorize(Roles = $"{RoleConstants.AdminRoleName},{RoleConstants.DeliveryDriverRoleName},{RoleConstants.CookingStaffRoleName}")]
        public async Task<IActionResult> OrderManagement(int page = 1)
        {
            if (page == 0)
            {
                page = 1;
            }
            int pageSize = 10;
            AllUserOrdersViewModel allOrders;
            try
            {
               allOrders = await _orderService.GetAllOrders();
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction("Index","Home");
            }
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize, allOrders.OrderModel);
            ViewBag.PageSize = pageSize;
            allOrders.OrderModel = (PageHelper.CalculateItemsForPage(page, pageSize, allOrders.OrderModel));
            return View(allOrders);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int pageNumber)
        {
            try
            {
                await _orderService.UpdateOrderStatus(orderId, GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = ae.Message;
                return RedirectToAction(nameof(OrderManagement), new { page = pageNumber});
            }
            return RedirectToAction(nameof(OrderManagement), new { page = pageNumber });
        }

    }
}
