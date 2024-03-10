using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusarovsQuckBite.Constants;
using Microsoft.EntityFrameworkCore;

namespace BusarovsQuckBite.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.ProductConstants.NameMaxLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.ProductConstants.DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Precision(DataConstants.ProductConstants.PricePrecision, DataConstants.ProductConstants.PriceScale)]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public virtual Category Category { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        public byte[] Image { get; set; } = null!;
        [Required]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public string Who { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Who))]
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
