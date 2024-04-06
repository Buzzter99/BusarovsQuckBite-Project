using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Areas.AccountManager.Models.Manage
{
    public class ResendEmailConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
