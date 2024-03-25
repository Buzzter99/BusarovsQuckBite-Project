using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Models
{
    public class OrderViewModel
    {
        public CartViewModel Cart { get; set; } = null!;
        public List<SelectListItem> PaymentType { get; set; } = new List<SelectListItem>();
        [Required]
        [DisplayName("Payment Type")]
        public string PaymentTypeValue { get; set; } = string.Empty;
        public List<AddressViewModel> Addresses { get; set; } = new List<AddressViewModel>();
        [Required]
        [DisplayName("Delivery Address")]
        public int? SelectedAddressId { get; set; }
    }
}
