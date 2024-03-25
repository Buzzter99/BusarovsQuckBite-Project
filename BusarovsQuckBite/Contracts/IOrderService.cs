using BusarovsQuckBite.Models;

namespace BusarovsQuckBite.Contracts
{
    public interface IOrderService
    {
        Task<OrderViewModel> ValidateOrderAsync(CartViewModel model,string userId);
    }
}
