using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuckBite.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public Category Category { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        [Required]
        public byte[] Image { get; set; } = null!;
    }
}
