using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuickBite.Infrastructure.Data.Models
{
    public class CartProduct
    {
        [Required]
        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; }
        [Required]
        public virtual Cart Cart { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [Required]
        public virtual Product Product { get; set; } = null!;
    }
}
