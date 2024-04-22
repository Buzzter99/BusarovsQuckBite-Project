namespace BusarovsQuickBite.Core.Contracts
{
    public interface IPasswordViewModel
    {
        string Password { get; set; }
        string ConfirmPassword { get; set; }
    }
}
