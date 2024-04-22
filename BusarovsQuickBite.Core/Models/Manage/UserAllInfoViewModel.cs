namespace BusarovsQuickBite.Core.Models.Manage
{
    public class UserAllInfoViewModel
    {
        public UpdateUserDataViewModel UpdateUserDataViewModel { get; set; } = null!;
        public ChangeUserPasswordViewModel ChangeUserPasswordViewModel { get; set; } = null!;
        public string ActiveTab { get; set; } = string.Empty;
    }
}
