using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Street { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string PostalCode { get; set; } = string.Empty;
        [Required]
        public string Country { get; set; } = string.Empty;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();

    }
}
