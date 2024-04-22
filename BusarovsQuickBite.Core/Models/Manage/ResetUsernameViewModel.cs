using System.ComponentModel.DataAnnotations;
using BusarovsQuickBite.Infrastructure.Constants;

namespace BusarovsQuickBite.Core.Models.Manage
{
    public class ResetUsernameViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please Submit Link Again!")]
        public string Token { get; set; } = string.Empty;
        [Required]
        [MinLength(UserConstants.UsernameMinLength)]
        [MaxLength(UserConstants.UsernameMaxLength)]
        public string NewUsername { get; set; } = string.Empty;
    }
}
