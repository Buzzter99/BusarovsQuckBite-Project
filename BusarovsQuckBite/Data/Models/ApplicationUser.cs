using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusarovsQuckBite.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
