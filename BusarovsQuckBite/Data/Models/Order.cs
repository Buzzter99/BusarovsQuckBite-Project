using BusarovsQuckBite.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuckBite.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Who { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Who))]

        public ApplicationUser User { get; set; } = null!;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }

        public OrderStatus Status { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        public int CartId { get; set; }

        [Required]
        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

    }
}
