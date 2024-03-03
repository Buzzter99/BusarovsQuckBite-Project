using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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

        public override Task<IdentityResult> CreateAsync(TUser user, string password)
        {
            if (_store.Users.Any(x => x.UserName == user.UserName))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError { Description = "Username is already registered" }));
            }
            if (_store.Users.Any(x => x.PhoneNumber == user.PhoneNumber))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError { Description = "Phone Number is already used" }));
            }
            if (_store.Users.Any(x => x.Email == user.Email))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError { Description = "Email is already registered" }));
            }
            return base.CreateAsync(user, password);
        }
        public async Task<List<AdministrationViewModel>> GetAllUsers()
        {
            var usersWithRoles = await _store.Context.Users
                .Select(c => new AdministrationViewModel()
                {
                    Id = c.Id,
                    Username = c.UserName,
                    IsActive = c.IsActive,
                    Email = c.Email,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    TransactionDateAndTime = c.TransactionDateAndTime,
                    Roles = _store.Context.UserRoles
                        .Where(ur => ur.UserId == c.Id)
                        .Select(ur => ur.RoleId)
                        .Join(_store.Context.Roles, ur => ur, r => r.Id, (ur, r) => r.Name)
                        .ToList()
                })
                .ToListAsync();
            return usersWithRoles;
        }

    }
}
