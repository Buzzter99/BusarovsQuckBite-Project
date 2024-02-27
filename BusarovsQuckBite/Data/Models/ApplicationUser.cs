using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace BusarovsQuckBite.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
        [Required]
        public override string Email { get; set; } = string.Empty;
        [Required]
        public override string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public override string PasswordHash { get; set; } = string.Empty;
        [Required]
        public bool IsActive { get; set; }
    }
}
