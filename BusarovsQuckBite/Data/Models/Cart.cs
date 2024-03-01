using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusarovsQuckBite.Constants;

namespace BusarovsQuckBite.Data.Models
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
        public ApplicationUser User { get; set; } = null!;
        public ICollection<CartProduct> Products { get; set; } = new List<CartProduct>();
    }
}
