using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Core.Contracts;

namespace BusarovsQuickBite.Core.Models.Manage
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
        [Required(ErrorMessage = "Please Submit Link Again!")]
        public string Token { get; set; } = string.Empty;
    }
}
