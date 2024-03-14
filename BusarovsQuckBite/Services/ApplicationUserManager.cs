using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Drawing.Printing;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace BusarovsQuckBite.Services
{
    public class ApplicationUserManager<TUser> : UserManager<TUser> where TUser : IdentityUser, new()
    {
        private readonly UserStore<TUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>
            _store;
        private readonly IDataProtectionService _protectionService;
        public ApplicationUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<TUser> passwordHasher, IEnumerable<IUserValidator<TUser>> userValidators, IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<TUser>> logger, IDataProtectionService protectionService)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _store = (UserStore<TUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>)store;
            _protectionService = protectionService;
        }

        public override Task<IdentityResult> CreateAsync(TUser user, string password)
        {
            var validateUser = ValidateUser(user, _store.Users);
            if (validateUser.Result.Any())
            {
                return Task.FromResult(IdentityResult.Failed(validateUser.Result.ToArray()));
            }
            return base.CreateAsync(user, password);
        }
        
        private async Task<List<RoleViewModel>> GetAllRoles()
        {
            return await _store.Context.Roles.Select(c => new RoleViewModel()
            {
                Id = c.Id,
                Name = c.Name
            }).AsNoTracking().ToListAsync();
        }
        public async Task<AdministrationViewModel> MapViewModel<TUser>(TUser user) where TUser : ApplicationUser
        {
            return new AdministrationViewModel()
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Roles = await GetAllRoles(),
                FirstName = user.FirstName == "" ? "" : _protectionService.Decrypt(user.FirstName!),
                LastName = user.LastName == "" ? "" : _protectionService.Decrypt(user.LastName!),
                IsActive = user.IsActive,
                TransactionDateAndTime = user.TransactionDateAndTime
            };
        }
        public async Task<bool> IsInRoleAsyncById(string userId, string roleName)
        {
            var user = await _store.FindByIdAsync(userId);
            var role = await _store.Context.Roles.FirstOrDefaultAsync(x => x.Name == roleName);
            if (role == null || user == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return await IsInRoleAsync(user, role.Name);
        }

        public async Task<(List<AdministrationViewModel>, int)> GetAllUsersByStatusAsync(string keyword, int pageSize, int page)
        {
            IQueryable<ApplicationUser> query = _store.Context.Users;
            var usersWithRoles = await query
                .Select(c => new AdministrationViewModel()
                {
                    Id = c.Id,
                    Username = c.UserName,
                    IsActive = c.IsActive,
                    Email = c.Email,
                    FirstName = c.FirstName == "" ? "" : _protectionService.Decrypt(c.FirstName!),
                    LastName = c.LastName == "" ? "" : _protectionService.Decrypt(c.LastName!),
                    RemainingLockoutTime = c.LockoutEnd == null ? 0 : c.LockoutEnd <= DateTimeOffset.Now ? 0 : (int)Math.Ceiling((c.LockoutEnd.Value - DateTimeOffset.Now).TotalSeconds),
                    PhoneNumber = c.PhoneNumber,
                    TransactionDateAndTime = c.TransactionDateAndTime,
                    Roles = _store.Context.UserRoles
                        .Where(ur => ur.UserId == c.Id)
                        .Select(ur => ur.RoleId)
                        .Join(_store.Context.Roles, ur => ur, r => r.Id, (ur, r) => 
                            new RoleViewModel { Name = r.Name })
                        .ToList()
                })
                .AsNoTracking()
                .ToListAsync();
            switch (keyword)
            {
                
                case "Active":
                    usersWithRoles = usersWithRoles.Where(x => x.IsActive).ToList();
                    break;
                case "Deactivated":
                    usersWithRoles = usersWithRoles.Where(x => !x.IsActive).ToList();
                    break;
            }
            int totalPages = (int)Math.Ceiling((double)(usersWithRoles.Count) / pageSize);
            usersWithRoles = usersWithRoles.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return (usersWithRoles, totalPages);
        }
        public override Task<IdentityResult> UpdateAsync(TUser user)
        {
            var validateUser = ValidateUser(user, _store.Users.Where(x => x.Id != user.Id));
            if (validateUser.Result.Any())
            {
                return Task.FromResult(IdentityResult.Failed(validateUser.Result.ToArray()));
            }
            return base.UpdateAsync(user);
        }
        private async Task<List<IdentityError>> ValidateUser(TUser user, IQueryable<TUser> collection)
        {
            var errors = new List<IdentityError>();
            if (await collection.FirstOrDefaultAsync(x => x.UserName == user.UserName) != null)
            {
                errors.Add(new IdentityError { Description = "Username is already registered" });
            }
            if (await collection.FirstOrDefaultAsync(x => x.Email == user.Email) != null)
            {
                errors.Add(new IdentityError { Description = "Email is already registered" });
            }
            if (await collection.FirstOrDefaultAsync(x => x.PhoneNumber == user.PhoneNumber) != null)
            {
                errors.Add(new IdentityError { Description = "Phone number is already registered" });
            }
            return await Task.FromResult(errors);
        }


    }
}
