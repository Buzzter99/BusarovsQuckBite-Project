using BusarovsQuckBite.Constants;
using System.ComponentModel.DataAnnotations;
using BusarovsQuckBite.Areas.AccountManager.Models.Interfaces;

namespace BusarovsQuckBite.Areas.AccountManager.Models.Administration
{
    public class AdministrationViewModel : IUserViewModel, IUserDataViewModel
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
        [RegularExpression(UserConstants.PhoneNumberValidationRegex, ErrorMessage = "Please provide valid Phone Number!")]
        public string PhoneNumber { get; set; } = string.Empty;
        [MinLength(UserConstants.FirstNameMinLength)]
        [MaxLength(UserConstants.FirstNameMaxLength)]
        public string? FirstName { get; set; } = string.Empty;
        [MinLength(UserConstants.LastNameMinLength)]
        [MaxLength(UserConstants.LastNameMaxLength)]
        public string? LastName { get; set; } = string.Empty;
        public int RemainingLockoutTime { get; set; }
    }
}
