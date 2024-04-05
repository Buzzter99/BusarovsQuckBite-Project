using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Areas.AccountManager.Models.Interfaces;
using BusarovsQuckBite.Constants;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class RegisterFormViewModel : IPasswordViewModel,IUserViewModel
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
        [RegularExpression(Constants.UserConstants.PhoneNumberValidationRegex,ErrorMessage = "Please provide valid Phone Number!")]
        public string PhoneNumber { get; set; } = string.Empty;


    }
}
