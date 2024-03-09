using BusarovsQuckBite.Constants;
using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class AdministrationViewModel
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        [MinLength(UserConstants.UsernameMinLength)]
        [MaxLength(UserConstants.UsernameMaxLength)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public List<RoleViewModel> Roles { get; set; } = new List<RoleViewModel>();
        public bool IsActive { get; set; }
        public DateTime TransactionDateAndTime { get; set; }
        [Required]
        [RegularExpression(Constants.UserConstants.PhoneNumberValidationRegex, ErrorMessage = "Please provide valid Phone Number!")]
        public string PhoneNumber { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
    }
}
