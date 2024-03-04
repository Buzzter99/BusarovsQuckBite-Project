using BusarovsQuckBite.Data.Models;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class AdministrationViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<RoleViewModel> Roles { get; set; } = new List<RoleViewModel>();
        public bool IsActive { get; set; }
        public DateTime TransactionDateAndTime { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
