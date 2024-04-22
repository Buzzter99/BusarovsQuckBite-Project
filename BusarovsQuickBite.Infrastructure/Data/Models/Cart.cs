using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Infrastructure.Data.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public string Who { get; set; } = string.Empty;
        [Required]
        public virtual ApplicationUser User { get; set; } = null!;
        public virtual ICollection<CartProduct> Products { get; set; } = new List<CartProduct>();
    }
}
