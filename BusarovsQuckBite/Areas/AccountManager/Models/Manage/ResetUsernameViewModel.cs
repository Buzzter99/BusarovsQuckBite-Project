using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Constants;

namespace BusarovsQuckBite.Areas.AccountManager.Models.Manage
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
