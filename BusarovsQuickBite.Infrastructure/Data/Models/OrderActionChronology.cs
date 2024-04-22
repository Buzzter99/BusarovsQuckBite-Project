using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Infrastructure.Data.Models
{
    public class OrderActionChronology
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.OrderConstants.OrderStatusMaxLength)]
        public string OldStatus { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.OrderConstants.OrderStatusMaxLength)]
        public string NewStatus { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        [Required]
        public virtual Order Order { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(User))]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public string Who { get; set; } = string.Empty;
        [Required]
        public virtual ApplicationUser User { get; set; } = null!;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
    }
}
