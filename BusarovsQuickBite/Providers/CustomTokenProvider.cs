using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BusarovsQuckBite.Providers
{
    public class CustomTokenProvider<TUser> : DataProtectorTokenProvider<TUser> where TUser : class
    {
        public CustomTokenProvider(IDataProtectionProvider dataProtectionProvider,
            IOptions<CustomTokenProviderOptions> options,
            ILogger<DataProtectorTokenProvider<TUser>> logger)
            : base(dataProtectionProvider, options, logger)
        {
            
        }

    }
}
