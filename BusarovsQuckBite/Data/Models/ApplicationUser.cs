using Microsoft.AspNetCore.Identity;
namespace BusarovsQuckBite.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime TransactionDateAndTime { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}
