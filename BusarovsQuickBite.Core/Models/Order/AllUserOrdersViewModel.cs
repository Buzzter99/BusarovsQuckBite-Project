using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuickBite.Core.Models.Order
{
    public class AllUserOrdersViewModel
    {
        public List<OrderUserViewModel> OrderModel { get; set; } = new List<OrderUserViewModel>();
        public List<SelectListItem> OrderStatuses { get; set; } = null!;
    }
}
