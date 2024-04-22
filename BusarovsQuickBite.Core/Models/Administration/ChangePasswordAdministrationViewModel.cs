using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Core.Contracts;

namespace BusarovsQuickBite.Core.Models.Administration
{
    public class ChangePasswordAdministrationViewModel : IPasswordViewModel
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
