using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuckBite.Data.Models
{
    public class CartProduct
    {
        [Required]
        [ForeignKey(nameof(Cart))]
        public int CartId { get; set; }
        [Required]
        public Cart Cart { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        [Required]
        public Product Product { get; set; } = null!;
    }
}
