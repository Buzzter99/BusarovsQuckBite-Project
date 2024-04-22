using System.ComponentModel.DataAnnotations;

namespace BusarovsQuickBite.Core.Models.Manage
{
    public class ResendEmailConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
