using BusarovsQuckBite.Contracts;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;

namespace BusarovsQuckBite.Services
{
    public class DataProtectionService : IDataProtectionService
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private const string Key = "my-very-long-key-of-no-exact-size";

        public DataProtectionService(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtectionProvider = dataProtectionProvider;
        }
        public string Encrypt(string input)
        {
            var protector = _dataProtectionProvider.CreateProtector(Key);
            return protector.Protect(input);
        }

        public string Decrypt(string cipherText)
        {
            var protector = _dataProtectionProvider.CreateProtector(Key);
            return protector.Unprotect(cipherText);
        }
    }
}
