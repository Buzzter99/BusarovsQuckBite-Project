using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IOrderService
    {
        Task<OrderViewModel> ValidateOrderAsync(OrderViewModel model, string userId);
        Task<int> PlaceOrder(OrderViewModel model, string userId);
        Task<AllUserOrdersViewModel> GetOrdersForUser(string userId);
        Task<int> GetOrderStatus(int id, string userId);

    }
}
