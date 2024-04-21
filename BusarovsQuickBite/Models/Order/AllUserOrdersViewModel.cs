using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusarovsQuckBite.Models.Order
{
    public class AllUserOrdersViewModel
    {
        public List<OrderUserViewModel> OrderModel { get; set; } = new List<OrderUserViewModel>();
        public List<SelectListItem> OrderStatuses { get; set; } = null!;
    }
}
