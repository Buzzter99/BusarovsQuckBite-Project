using BusarovsQuckBite.Data.Models;

namespace BusarovsQuckBite.Areas.AccountManager.Models
{
    public class AdministrationViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> Roles { get; set; } = new List<string>();
        public bool IsActive { get; set; }
        public DateTime TransactionDateAndTime { get; set; }
    }
}
