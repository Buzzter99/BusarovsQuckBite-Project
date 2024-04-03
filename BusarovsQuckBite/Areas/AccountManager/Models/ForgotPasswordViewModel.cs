using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Compare(nameof(Password))]
        public string PasswordConfirm { get; set; } = string.Empty;
        [Required]
        public string Token { get; set; } = string.Empty;
    }
}
