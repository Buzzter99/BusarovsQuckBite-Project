using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Models.Order
{
    public class OrderMessageViewModel
    {
        public int OrderId { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
    }
}
