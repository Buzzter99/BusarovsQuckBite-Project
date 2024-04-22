using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Core.Models.Address
{
    public class AddressViewModel
    {
        [Required]
        public int AddressId { get; set; }
        [Required]
        [MinLength(DataConstants.AddressConstants.StreetMinLength)]
        [MaxLength(DataConstants.AddressConstants.StreetMaxLength)]
        public string Street { get; set; } = string.Empty;
        [Required]
        [MinLength(DataConstants.AddressConstants.CityMinLength)]
        [MaxLength(DataConstants.AddressConstants.CityMaxLength)]
        public string City { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
    }
}
