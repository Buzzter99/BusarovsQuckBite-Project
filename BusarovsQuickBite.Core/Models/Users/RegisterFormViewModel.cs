using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Core.Models.Users
{
    public class RegisterFormViewModel : IPasswordViewModel, IUserViewModel
    {
        [Required]
        [MinLength(UserConstants.UsernameMinLength)]
        [MaxLength(UserConstants.UsernameMaxLength)]

        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [RegularExpression(UserConstants.PhoneNumberValidationRegex, ErrorMessage = "Please provide valid Phone Number!")]
        public string PhoneNumber { get; set; } = string.Empty;


    }
}
