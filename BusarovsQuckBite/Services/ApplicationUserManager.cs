using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BusarovsQuckBite.Services
{
    public class ApplicationUserManager<TUser> : UserManager<TUser> where TUser : IdentityUser, new()
    {
        private readonly UserStore<TUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>
            _store;
        private readonly IDataProtectionService _protectionService;
        public ApplicationUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<TUser> passwordHasher, IEnumerable<IUserValidator<TUser>> userValidators, IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<TUser>> logger,IDataProtectionService protectionService)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _store = (UserStore<TUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>)store;
            _protectionService = protectionService;
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
                        .Join(_store.Context.Roles, ur => ur, r => r.Id, (ur, r) => new RoleViewModel { Id = r.Id, Name = r.Name })
                        .ToList()
                })
                .ToListAsync();
            return usersWithRoles;
        }
        private async Task<List<RoleViewModel>> GetAllRoles<TUser>(TUser user) where TUser : ApplicationUser
        {
            return await _store.Context.Roles.Select(c => new RoleViewModel()
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();
        }
        public async Task<AdministrationViewModel> MapViewModel<TUser>(TUser user) where TUser : ApplicationUser
        {
            return new AdministrationViewModel()
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Roles = await GetAllRoles(user),
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsActive = user.IsActive,
                TransactionDateAndTime = user.TransactionDateAndTime
            };
        }
        public async Task<bool> IsInRoleAsyncById(string userId, string roleId)
        {
            var user = await _store.FindByIdAsync(userId);
            var role = await _store.Context.Roles.FirstOrDefaultAsync(x => x.Id == roleId);
            if (role == null || user == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return await IsInRoleAsync(user, role.Name);
        }

        public async Task<List<AdministrationViewModel>> GetAllActiveUsersAsync()
        {
            var usersWithRoles = await _store.Context.Users.Where(x => x.IsActive)
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
                        .Join(_store.Context.Roles, ur => ur, r => r.Id, (ur, r) => new RoleViewModel { Id = r.Id, Name = r.Name })
                        .ToList()
                })
                .ToListAsync();
            return usersWithRoles;
        }

        public async Task<List<AdministrationViewModel>> GetAllDeactivatedUsersAsync()
        {
            var usersWithRoles = await _store.Context.Users.Where(x => !x.IsActive)
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
                        .Join(_store.Context.Roles, ur => ur, r => r.Id, (ur, r) => new RoleViewModel { Id = r.Id, Name = r.Name })
                        .ToList()
                })
                .ToListAsync();
            return usersWithRoles;
        }
    }
}
