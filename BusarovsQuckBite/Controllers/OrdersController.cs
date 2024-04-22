using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Enums;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.Cart;
using BusarovsQuickBite.Core.Models.Order;
using BusarovsQuickBite.Core.Models.PageHelpers;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

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
            OrderViewModel orderView = new OrderViewModel() { Cart = model };
            try
            {
                orderView = await _orderService.ValidateOrderAsync(orderView, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction("MyCart", "Cart");
            }
            return View(orderView);
        }

        [HttpPost]
        public async Task<IActionResult> PlaceOrder(OrderViewModel model)
        {
            try
            {
                model = await _orderService.ValidateOrderAsync(model, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction("MyCart", "Cart");
            }
            if (!ModelState.IsValid)
            {
                return View(nameof(MyOrder), model);
            }
            try
            {
                await _orderService.PlaceOrder(model, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
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
            var ordersForUser = await _orderService.GetOrdersForUser(User.Identity.GetUserId());
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize, ordersForUser.OrderModel) == 0 ? 1 : PageHelper.CalculateTotalPages(pageSize, ordersForUser.OrderModel);
            ViewBag.PageSize = pageSize;
            ordersForUser.OrderModel = PageHelper.CalculateItemsForPage(page, pageSize, ordersForUser.OrderModel);
            if (ViewBag.TotalPages < page || page <= 0)
            {
                return RedirectToAction(nameof(Orders));
            }
            return View(ordersForUser);
        }
        public async Task<IActionResult> TrackOrder(TrackOrderViewModel model)
        {
            try
            {
               model.Percentage = await _orderService.GetOrderStatusAsync(model.Id,User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(Orders));
            }
            return View(model);
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
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction("Index","Home");
            }
            ViewBag.PageNumber = page;
            ViewBag.TotalPages = PageHelper.CalculateTotalPages(pageSize, allOrders.OrderModel) == 0 ? 1 : PageHelper.CalculateTotalPages(pageSize, allOrders.OrderModel);
            ViewBag.PageSize = pageSize;
            allOrders.OrderModel = PageHelper.CalculateItemsForPage(page, pageSize, allOrders.OrderModel);
            if (ViewBag.TotalPages < page || page <= 0)
            {
                return RedirectToAction(nameof(OrderManagement));
            }
            return View(allOrders);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateOrderStatus(int orderId, int pageNumber)
        {
            try
            {
                await _orderService.UpdateOrderStatus(orderId, User.Identity.GetUserId());
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(OrderManagement), new { page = pageNumber});
            }
            return RedirectToAction(nameof(OrderManagement), new { page = pageNumber });
        }
        [Authorize(Roles = $"{RoleConstants.AdminRoleName},{RoleConstants.DeliveryDriverRoleName},{RoleConstants.CookingStaffRoleName}")]
        public async Task<IActionResult> SendMessage(OrderMessageViewModel messageInfo)
        {
            Order order;
            try
            {
                order = await _orderService.GetByIdAsync(messageInfo.OrderId);
            }
            catch (ApplicationException ae)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ae.Message);
                return RedirectToAction(nameof(OrderManagement));
            }
            if (messageInfo.OrderStatus.ToUpper() != order.Status.ToString().ToUpper())
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode(ErrorMessagesConstants.GeneralErrorMessage);
                return RedirectToAction(nameof(OrderManagement));
            }
            if (order.Status == OrderStatus.Delivered)
            {
                TempData[ErrorMessagesConstants.FailedMessageKey] = HtmlEncoder.Default.Encode("Cannot send message to delivered order!");
                return RedirectToAction(nameof(OrderManagement));
            }
            return View(messageInfo);
        }

    }
}
