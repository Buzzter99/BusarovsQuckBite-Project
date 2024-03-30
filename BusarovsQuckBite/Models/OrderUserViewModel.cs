using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Data.Enums;

namespace BusarovsQuckBite.Models
{
    public class OrderUserViewModel
    {
        public int Id { get; set; }
        public PaymentType PaymentType { get; set; }
        public string OrderPlacedDate { get; set; } = string.Empty;
        public OrderStatus OrderStatus { get; set; }
        public AddressViewModel DeliveryAddress { get; set; } = null!;
        public List<ProductViewModel> OrderProducts { get; set; } = null!;
        public AdministrationViewModel User { get; set; } = null!;
        public int AddressId { get; set; }
    }
}
