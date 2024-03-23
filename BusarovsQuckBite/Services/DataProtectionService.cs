using BusarovsQuckBite.Contracts;
using Microsoft.AspNetCore.DataProtection;

namespace BusarovsQuckBite.Services
{
    public class DataProtectionService : IDataProtectionService
    {
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private readonly IConfiguration _configuration;

        public DataProtectionService(IDataProtectionProvider dataProtectionProvider, IConfiguration configuration)
        {
            _dataProtectionProvider = dataProtectionProvider;
            _configuration = configuration;
        }
        public string Encrypt(string input)
        {
            var protector = _dataProtectionProvider.CreateProtector(GetKey());
            return protector.Protect(input);
        }

        public string Decrypt(string cipherText)
        {
            var protector = _dataProtectionProvider.CreateProtector(GetKey());
            return protector.Unprotect(cipherText);
        }
        private string GetKey()
        {
            return  _configuration.GetValue<string>("EncryptionKeys:DefaultKey");
        }
    }
}
