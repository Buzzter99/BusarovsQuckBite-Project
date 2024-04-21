namespace BusarovsQuckBite.Areas.AccountManager.Models.Interfaces
{
    public interface IUserViewModel
    {
        string Username { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
    }
}
