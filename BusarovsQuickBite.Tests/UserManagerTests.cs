using BusarovsQuickBite.Core.Services;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Text;
using BusarovsQuickBite.Core.Models.Administration;
using BusarovsQuickBite.Core.Models.Enums;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private ApplicationUserManager<ApplicationUser> _userManager;
        private UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>> _store;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private DataProtectionService? _dataProtectionService;
        private ApplicationUser? _user;
        [SetUp]
        public void SetUp()
        {
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _store = new UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>,
                IdentityRoleClaim<string>>(_context);
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string> { })
                .Build();
            var mockDataProtector = new Mock<IDataProtector>();
            mockDataProtector
                .Setup(sut => sut.Protect(It.IsAny<byte[]>()))
                .Returns<byte[]>(data =>
                    { string encryptedData = Convert.ToBase64String(data); return Encoding.UTF8.GetBytes(encryptedData); });
            mockDataProtector
                .Setup(sut => sut.Unprotect(It.IsAny<byte[]>()))
                .Returns<byte[]>(data =>
                    { string decryptedData = Encoding.UTF8.GetString(data); return Convert.FromBase64String(decryptedData); });
            var mockDataProtectionProvider = new Mock<IDataProtectionProvider>();
            mockDataProtectionProvider
                .Setup(s => s.CreateProtector(It.IsAny<string>())).Returns(mockDataProtector.Object);
            _dataProtectionService = new DataProtectionService(mockDataProtectionProvider.Object, configuration);
            _userManager = new ApplicationUserManager<ApplicationUser>(_store,
                null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null, _dataProtectionService);
            _user = new ApplicationUser
            {
                UserName = "Test",
                Email = "Test@test.bg",
                PhoneNumber = "0878450345"
            };
        }

        [TearDown]
        public void TearDown()
        {
            _userManager.Dispose();
            _store.Dispose();
            _context!.Database.EnsureDeleted();
        }
        [Test]
        public async Task CreateUserTest()
        {
            var result = await _userManager.CreateAsync(_user!, "000000");
            Assert.IsTrue(result.Succeeded);
            var emailExist = new ApplicationUser();
            emailExist.Email = _user!.Email;
            var error1 = await _userManager.CreateAsync(emailExist, "000000");
            Assert.IsFalse(error1.Succeeded);
            var usernameExists = new ApplicationUser();
            usernameExists.UserName = _user.UserName;
            var error2 = await _userManager.CreateAsync(usernameExists, "000000");
            Assert.IsFalse(error2.Succeeded);
            var phoneExists = new ApplicationUser();
            phoneExists.PhoneNumber = _user.PhoneNumber;
            var error3 = await _userManager.CreateAsync(phoneExists, "000000");
            Assert.IsFalse(error3.Succeeded);
        }

        [Test]
        public async Task MapViewModelTest()
        {
            var user = await _userManager.FindByIdAsync(UserConstants.AdminId);
            var getRoles = _context!.Roles.Count();
            var execute = await _userManager.MapViewModel(user);
            Assert.IsNotNull(execute);
            Assert.That(execute.Email, Is.EqualTo(UserConstants.AdminEmail));
            Assert.That(execute.Id, Is.EqualTo(UserConstants.AdminId));
            Assert.That(execute.Username, Is.EqualTo(UserConstants.AdminUsername));
            Assert.That(execute.PhoneNumber, Is.EqualTo(UserConstants.AdminPhoneNumber));
            Assert.That(execute.FirstName, Is.EqualTo(""));
            Assert.That(execute.LastName, Is.EqualTo(""));
            Assert.IsTrue(execute.IsActive);
            Assert.That(execute.TransactionDateAndTime, Is.EqualTo(user.TransactionDateAndTime));
            Assert.That(execute.Roles.Count, Is.EqualTo(getRoles));
        }
        [Test]
        public async Task MapViewModelWithEncryptedData()
        {
            _user.FirstName = _dataProtectionService!.Encrypt("firstName");
            _user.LastName = _dataProtectionService!.Encrypt("lastName");
            var create = await _userManager.CreateAsync(_user, "000000");
            var mapModel = await _userManager.MapViewModel(_user);
            Assert.IsNotNull(mapModel);
            Assert.That(mapModel.FirstName, Is.EqualTo("firstName"));
            Assert.That(mapModel.LastName, Is.EqualTo("lastName"));
        }
        [Test]
        public async Task MapPasswordTest()
        {
            var entity = await _userManager.FindByIdAsync(UserConstants.AdminId);
            var mapModel = _userManager.MapPasswordViewModel(entity);
            Assert.IsNotNull(mapModel);
            Assert.That(mapModel.Id, Is.EqualTo(entity.Id));
            Assert.That(mapModel.Username, Is.EqualTo(entity.UserName));
        }
        [Test]
        public void IsInRoleByIdShouldThrowTest()
        {
            Assert.ThrowsAsync<ApplicationException>(async () => await _userManager.IsInRoleAsyncById(UserConstants.AdminId, "test"));
            Assert.ThrowsAsync<ApplicationException>(async () => await _userManager.IsInRoleAsyncById("123", RoleConstants.AdminRoleName));
            Assert.ThrowsAsync<ApplicationException>(async () => await _userManager.IsInRoleAsyncById("notRealUserId", "notRealRole"));
        }
        [Test]
        public async Task MapInfoForUserTest()
        {
            var user = await _userManager.FindByIdAsync(UserConstants.AdminId);
            var mapModel = _userManager.MapInfoForUser(user);
            Assert.IsNotNull(mapModel);
            Assert.That(mapModel.Email, Is.EqualTo(user.Email));
            Assert.That(mapModel.PhoneNumber, Is.EqualTo(user.PhoneNumber));
            Assert.That(mapModel.Username, Is.EqualTo(user.UserName));
            Assert.That(mapModel.FirstName, Is.EqualTo(user.FirstName));
            Assert.That(mapModel.LastName, Is.EqualTo(user.LastName));
        }
        [Test]
        public async Task MapInfoForUserWithEncryptedData()
        {
            _user.FirstName = _dataProtectionService!.Encrypt("firstName");
            _user.LastName = _dataProtectionService!.Encrypt("lastName");
            await _userManager.CreateAsync(_user, "000000");
            var mapModel = _userManager.MapInfoForUser(_user);
            Assert.IsNotNull(mapModel);
            Assert.That(mapModel.FirstName, Is.EqualTo("firstName"));
            Assert.That(mapModel.LastName, Is.EqualTo("lastName"));
        }
        [Test]
        public async Task EditRequiredUserDataTest()
        {
            var appUser = new ApplicationUser
            {
                UserName = "abv",
                Email = "abv@abv.bg",
                PhoneNumber = "1234567890",
            };
            var user = await _userManager.CreateAsync(appUser, "000000");
            var adminModel = new AdministrationViewModel
            {
                Email = "newEmail@hotmail.com",
                PhoneNumber = "123455678",
                Username = "newUsername"
            };
            var editData = _userManager.EditRequiredUserData(appUser, adminModel);
            Assert.IsNotNull(editData);
            Assert.That(editData.Email, Is.EqualTo(adminModel.Email));
            Assert.That(editData.PhoneNumber, Is.EqualTo(adminModel.PhoneNumber));
            Assert.That(editData.UserName, Is.EqualTo(adminModel.Username));
            Assert.That(editData.FirstName, Is.EqualTo(""));
            Assert.That(editData.LastName, Is.EqualTo(""));
        }
        [Test]
        public async Task EditRequiredUserDataWitEncryptedDataTest()
        {
            var appUser = new ApplicationUser
            {
                UserName = "abv",
                Email = "abv@abv.bg",
                PhoneNumber = "1234567890",
            };
            var user = await _userManager.CreateAsync(appUser, "000000");
            var adminModel = new AdministrationViewModel
            {
                Email = "newEmail@hotmail.com",
                PhoneNumber = "123455678",
                Username = "newUsername",
                FirstName = "testFirstName",
                LastName = "testLastName"
            };
            var editData = _userManager.EditRequiredUserData(appUser, adminModel);
            Assert.IsNotNull(editData);
            Assert.That(editData.LastName, Is.Not.EqualTo(""));
            Assert.That(editData.FirstName, Is.Not.EqualTo(""));
            string decryptedFirstName = _dataProtectionService!.Decrypt(editData.FirstName!);
            string decryptedLastName = _dataProtectionService!.Decrypt(editData.LastName!);
            Assert.That(decryptedFirstName,Is.EqualTo(adminModel.FirstName));
            Assert.That(decryptedLastName, Is.EqualTo(adminModel.LastName));
        }
        [Test]
        public async Task GetUserByStatusTest()
        {
            _user.IsActive = false;
            var deactivatedUser = await _userManager.CreateAsync(_user, "000000");
            var allUsers = await _userManager.GetAllUsersByStatusAsync(FilterEnum.All);
            Assert.IsNotNull(allUsers);
            var count = EnumHelper.GetEnumSelectList<FilterEnum>().Count;
            Assert.That(allUsers.FilterOptions.Count, Is.EqualTo(count));
            Assert.That(allUsers.AdministrationDataModel.Count, Is.EqualTo(_context!.Users.Count()));
            var activeUsers = await _userManager.GetAllUsersByStatusAsync(FilterEnum.Active);
            var deactivatedUsers = await _userManager.GetAllUsersByStatusAsync(FilterEnum.Deleted);
            Assert.IsNotNull(activeUsers);
            Assert.IsNotNull(deactivatedUsers);
            Assert.That(activeUsers.AdministrationDataModel.Count,Is.EqualTo(1));
            Assert.That(deactivatedUsers.AdministrationDataModel.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task UpdateUserNameShouldFail()
        {
            var user = new ApplicationUser
            {
                UserName = "test12345",
                Email = "test@abv.bg",
                PhoneNumber = "1234567890"
            };
            await _userManager.CreateAsync(user, "000000");
            user.UserName = UserConstants.AdminUsername;
            var userNameShouldFail = await _userManager.UpdateAsync(user);
            Assert.IsFalse(userNameShouldFail.Succeeded);
        }
        [Test]
        public async Task UpdateEmailShouldFail()
        {
            var user = new ApplicationUser
            {
                UserName = "test12345",
                Email = "test@abv.bg",
                PhoneNumber = "1234567890"
            };
            await _userManager.CreateAsync(user, "000000");
            user.Email = UserConstants.AdminEmail;
            var emailShouldFail = await _userManager.UpdateAsync(user);
            Assert.IsFalse(emailShouldFail.Succeeded);
        }
        [Test]
        public async Task UpdatePhoneNumberShouldFail()
        {
            var user = new ApplicationUser
            {
                UserName = "test12345",
                Email = "test@abv.bg",
                PhoneNumber = "1234567890"
            };
            await _userManager.CreateAsync(user, "000000");
            user.PhoneNumber = UserConstants.AdminPhoneNumber;
            var phoneNumberShouldFail = await _userManager.UpdateAsync(user);
            Assert.IsFalse(phoneNumberShouldFail.Succeeded);
        }

        [Test]
        public async Task UpdateShouldWork()
        {
            var user = new ApplicationUser
            {
                UserName = "test12345",
                Email = "test@abv.bg",
                PhoneNumber = "1234567890"
            };
            await _userManager.CreateAsync(user, "000000");
            user.UserName = "Updated";
            user.Email = "Updated@abv.bg";
            user.PhoneNumber = "1234567891";
            var shouldBeTrue = await _userManager.UpdateAsync(user);
            Assert.IsTrue(shouldBeTrue.Succeeded);
        }
    }

}
