using BusarovsQuickBite.Core.Models.Address;
using BusarovsQuickBite.Core.Models.Administration;
using BusarovsQuickBite.Core.Models.Product;
using BusarovsQuickBite.Infrastructure.Data.Enums;

namespace BusarovsQuickBite.Core.Models.Order
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
