using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusarovsQuickBite.Core.Models.Users
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
