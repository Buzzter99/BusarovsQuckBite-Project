using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

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
