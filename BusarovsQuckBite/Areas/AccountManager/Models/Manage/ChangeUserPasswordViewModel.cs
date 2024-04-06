using BusarovsQuckBite.Areas.AccountManager.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Areas.AccountManager.Models.Manage
{
    public class ChangeUserPasswordViewModel : IPasswordViewModel
    {
        [Required]
        public string OldPassword { get; set; } = string.Empty;
        [Required]
        [Compare(nameof(ConfirmPassword))]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
