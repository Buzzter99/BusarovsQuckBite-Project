using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuckBite.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Address Address { get; set; } = null!;
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
    }
}
