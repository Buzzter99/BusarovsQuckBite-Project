using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Core.Contracts;

namespace BusarovsQuickBite.Core.Models.Manage
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
