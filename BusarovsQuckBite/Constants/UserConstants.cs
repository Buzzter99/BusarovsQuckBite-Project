namespace BusarovsQuckBite.Constants
{
    public static class UserConstants
    {
        public const string PhoneNumberValidationRegex = @"(\+\d{1,3}\s?)?((\(\d{3}\)\s?)|(\d{3})(\s|-?))(\d{3}(\s|-?))(\d{4})(\s?(([E|e]xt[:|.|]?)|x|X)(\s?\d+))?";
        public const int UserIdMaxLength = 40;
        public const int FirstNameMinLength = 3;
        public const int FirstNameMaxLength = 150;
        public const int LastNameMinLength = 3;
        public const int LastNameMaxLength = 150;
        public const int UsernameMinLength = 5;
        public const int UsernameMaxLength = 150;
        public const string AdminUsername = "Admin";
        public const string AdminEmail = "brandabg1@gmail.com";
        public const string AdminPhoneNumber = "0896722926";
    }
}
