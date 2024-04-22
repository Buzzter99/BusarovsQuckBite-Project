using BusarovsQuickBite.Core.Models.Order;
using BusarovsQuickBite.Infrastructure.Data.Models;

namespace BusarovsQuickBite.Core.Contracts
{
    public interface IOrderService
    {
        Task<OrderViewModel> ValidateOrderAsync(OrderViewModel model, string userId);
        Task<int> PlaceOrder(OrderViewModel model, string userId);
        Task<AllUserOrdersViewModel> GetOrdersForUser(string userId);
        Task<int> GetOrderStatusAsync(int id, string userId);
        Task<AllUserOrdersViewModel> GetAllOrders();
        Task<Order> GetByIdAsync(int id);
        Task UpdateOrderStatus(int orderId, string userId);
    }
}
