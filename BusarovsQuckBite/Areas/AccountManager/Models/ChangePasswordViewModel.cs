using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class ChangePasswordViewModel
    {
        [Required]
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
    }
}
