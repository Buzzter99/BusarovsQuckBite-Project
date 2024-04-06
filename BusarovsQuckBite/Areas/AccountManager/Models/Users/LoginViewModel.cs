using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusarovsQuckBite.Areas.AccountManager.Models.Users
{
    public class LoginViewModel
    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
