using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusarovsQuckBite.Data.Enums;
using Microsoft.AspNetCore.Identity;

namespace BusarovsQuckBite.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Orderer { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Orderer))]

        public virtual IdentityUser User { get; set; } = null!;

        public string? SpecialWishes { get; set; } = string.Empty;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public int CartId { get; set; }

        [Required]
        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

    }
}
