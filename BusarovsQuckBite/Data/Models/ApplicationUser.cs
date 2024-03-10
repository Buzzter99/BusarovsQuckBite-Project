using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Constants;
using Microsoft.AspNetCore.Identity;
namespace BusarovsQuckBite.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public override string Id { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [MaxLength(UserConstants.FirstNameMaxLength)]
        public string? FirstName { get; set; } = string.Empty;
        [MaxLength(UserConstants.LastNameMaxLength)]
        public string? LastName { get; set; } = string.Empty;
        [Required]
        [MaxLength(UserConstants.UsernameMaxLength)]
        public override string UserName { get; set; } = string.Empty;
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
        public virtual ICollection<Category> Categories { get; set; } = new List<Category>();
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
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
