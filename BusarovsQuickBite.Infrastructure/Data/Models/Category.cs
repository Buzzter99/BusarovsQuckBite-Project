using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.CategoryConstants.CategoryMaxLength)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public string Who { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Who))]
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
