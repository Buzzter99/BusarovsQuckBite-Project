using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BusarovsQuckBite.Services
{
    public class ApplicationUserManager<TUser> : UserManager<TUser> where TUser : IdentityUser
    {
        private readonly UserStore<TUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>
            _store;
        public ApplicationUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<TUser> passwordHasher, IEnumerable<IUserValidator<TUser>> userValidators, IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<TUser>> logger) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _store = (UserStore<TUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>)store;
        }
    }
}
