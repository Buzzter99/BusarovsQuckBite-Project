using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Data.Models
{
    public class ApplicationRole : IdentityRole
    {
        [Required]
        public override string Name { get; set; } = string.Empty;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
    }
}
