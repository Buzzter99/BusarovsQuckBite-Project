using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BusarovsQuickBite.Core.Services
{
    public class ApplicationSignInManager<T> : SignInManager<T> where T : ApplicationUser
    {
        public ApplicationSignInManager(UserManager<T> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<T> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<T>> logger, IAuthenticationSchemeProvider schemes, IUserConfirmation<T> confirmation) 
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
        {
        }
        public  override async Task<bool> CanSignInAsync(T user)
        {
            if (user.IsActive == false)
            {
                return false;
            }
            return await base.CanSignInAsync(user);
        }
    }
}
