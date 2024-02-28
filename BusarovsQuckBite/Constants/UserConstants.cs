using Microsoft.AspNetCore.Authorization;

namespace BusarovsQuckBite.Constants
{
    public class UserConstants
    {
        public const string PhoneNumberValidationRegex = @"(\+\d{1,3}\s?)?((\(\d{3}\)\s?)|(\d{3})(\s|-?))(\d{3}(\s|-?))(\d{4})(\s?(([E|e]xt[:|.|]?)|x|X)(\s?\d+))?";
    }
}
