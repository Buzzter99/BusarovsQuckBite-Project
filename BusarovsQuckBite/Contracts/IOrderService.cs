using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IOrderService
    {
        Task<OrderViewModel> ValidateOrderAsync(OrderViewModel model, string userId);
        Task PlaceOrder(OrderViewModel model, string userId);
    }
}
