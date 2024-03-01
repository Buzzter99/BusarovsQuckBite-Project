using BusarovsQuckBite.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BusarovsQuckBite.Constants.DataConstants;

namespace BusarovsQuckBite.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(AddressConstants.StreetMaxLength)]
        public string Street { get; set; } = string.Empty;
        [Required]
        [MaxLength(AddressConstants.CityMaxLength)]
        public string City { get; set; } = string.Empty;
        [Required]
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        [MaxLength(UserConstants.UserIdMaxLength)]
        public string Who { get; set; } = string.Empty;
        [Required]
        [ForeignKey(nameof(Who))]
        public ApplicationUser User { get; set; } = null!;

    }
}
