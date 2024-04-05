using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Areas.AccountManager.Models.Interfaces;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class ForgotPasswordViewModel : IPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
        [Required]
        public string Token { get; set; } = string.Empty;
    }
}
