using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Core.Models.Manage
{
    public class UpdateUserDataViewModel : IUserViewModel, IUserDataViewModel
    {
        [MinLength(UserConstants.FirstNameMinLength)]
        [MaxLength(UserConstants.FirstNameMaxLength)]
        public string? FirstName { get; set; } = string.Empty;
        [MinLength(UserConstants.LastNameMinLength)]
        [MaxLength(UserConstants.LastNameMaxLength)]
        public string? LastName { get; set; } = string.Empty;
        [Required]
        [MinLength(UserConstants.UsernameMinLength)]
        [MaxLength(UserConstants.UsernameMaxLength)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [RegularExpression(UserConstants.PhoneNumberValidationRegex, ErrorMessage = "Please provide valid Phone Number!")]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
