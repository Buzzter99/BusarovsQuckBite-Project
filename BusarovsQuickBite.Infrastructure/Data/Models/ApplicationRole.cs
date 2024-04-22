using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BusarovsQuickBite.Infrastructure.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        [Required]
        public override string Name { get; set; } = string.Empty;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
    }
}
