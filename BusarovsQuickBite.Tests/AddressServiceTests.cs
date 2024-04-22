using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.Address;
using BusarovsQuickBite.Core.Services;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data;
using BusarovsQuickBite.Infrastructure.Data.Common;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Text;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class AddressServiceTests
    {
        private IAddressService? _addressService;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private IDataProtectionService? _dataProtectionService;
        [SetUp]
        public void Setup()
        {
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
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _addressService = new AddressService(new Repository(_context),_dataProtectionService);
        }
        [TearDown]
        public void TearDown()
        {
            _context!.Database.EnsureDeleted();
        }
        [Test]
        public async Task AddAddressToUser()
        {
            var address = new AddressViewModel()
            {
                Street = "Illinois 103",
                City = "SomewhereInTheWorld"
            };
            await _addressService!.AddAddress(address, UserConstants.AdminId);
            var findAddress = await _context!.Addresses.Where(x => x.Who == UserConstants.AdminId).FirstAsync();
            Assert.IsNotNull(findAddress);
            Assert.That(_dataProtectionService!.Decrypt(findAddress.City),Is.EqualTo(address.City));
            Assert.That(_dataProtectionService!.Decrypt(findAddress.Street), Is.EqualTo(address.Street));
            Assert.IsFalse(findAddress.IsDeleted);
            Assert.That(findAddress.Who,Is.EqualTo(UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService.AddAddress(new AddressViewModel()
            {
                Street = "Test",
                City = "Test"
            },UserConstants.AdminId));
            var addressShouldBeAdded = _context.Addresses.Count(x => x.Who == UserConstants.AdminId);
            Assert.That(addressShouldBeAdded,Is.EqualTo(1));
        }

        [Test]
        public async Task GetByIdForUserTest()
        {
            var address = new AddressViewModel()
            {
                City = "Sofia",
                Street = "AlaBala 100"
            };
            await _addressService!.AddAddress(address, UserConstants.AdminId);
            var addressFromDb = await _context!.Addresses.FirstAsync(x => x.Who == UserConstants.AdminId);
            var result = await _addressService.GetByIdForUser(addressFromDb.Id, UserConstants.AdminId);
            Assert.That(result.City,Is.EqualTo(address.City));
            Assert.That(result.Street,Is.EqualTo(address.Street));
            Assert.That(addressFromDb.Id,Is.EqualTo(result.AddressId));
            Assert.That(addressFromDb.IsDeleted, Is.EqualTo(result.IsDeleted));
        }
        [Test]
        public async Task GetByIdShouldThrowTest()
        {
            int randomId = 12321;
            string randomUserId = Guid.NewGuid().ToString();
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService!.GetByIdForUser(-1,randomUserId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService!.GetByIdForUser(0, randomUserId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService!.GetByIdForUser(randomId, randomUserId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService!.GetByIdForUser(randomId, UserConstants.AdminId));
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Burgas",
                Street = "Test 123"
            },UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            Assert.DoesNotThrowAsync(async () => await _addressService!.GetByIdForUser(address.Id, UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService!.GetByIdForUser(address.Id, Guid.NewGuid().ToString()));
        }
        [Test]
        public async Task DeleteAddressShouldWork()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Burgas",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            await _addressService.DeleteAddress(address.Id, address.Who);
            Assert.IsTrue(address.IsDeleted);
        }
        [Test]
        public async Task DeleteAddressShouldThrow()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Burgas",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService.DeleteAddress(1023210,UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService.DeleteAddress(address.Id, Guid.NewGuid().ToString()));
            Assert.DoesNotThrowAsync(async () => await _addressService.DeleteAddress(address.Id,UserConstants.AdminId));
        }
        [Test]
        public async Task GetAddressesForUserTest()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Burgas",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var expected = _context!.Addresses.Count(x => x.Who == UserConstants.AdminId);
            var collection = await _addressService.GetAddressesForUserAsync(UserConstants.AdminId);
            Assert.IsNotNull(collection);
            Assert.That(expected, Is.EqualTo(collection.Count));
            var empty = await _addressService.GetAddressesForUserAsync(Guid.NewGuid().ToString());
            Assert.That(empty.Count, Is.EqualTo(0));
        }
        [Test]
        public async Task ActiveAddressesForUserTest()
        {
            var empty = await _addressService!.GetActiveAddressesForUser(UserConstants.AdminId);
            Assert.That(empty.Count,Is.EqualTo(0));
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Burgas",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var shouldContainAddress = await _addressService.GetActiveAddressesForUser(UserConstants.AdminId);
            var count = await _context!.Addresses.Where(x => x.Who == UserConstants.AdminId).ToListAsync();
            Assert.That(shouldContainAddress.Count,Is.EqualTo(count.Count));
            await _addressService.DeleteAddress(count.First().Id, UserConstants.AdminId);
            var emptyAfterDelete = await _addressService.GetActiveAddressesForUser(UserConstants.AdminId);
            Assert.That(emptyAfterDelete.Count,Is.EqualTo(_context.Addresses.Count(x => x.Who == UserConstants.AdminId && !x.IsDeleted)));
        }
        [Test]
        public async Task EditAddressShouldThrow()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Burgas",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync(x => x.Who == UserConstants.AdminId);
            var viewModel = new AddressViewModel
            {
                AddressId = 1232,
                Street = "ShouldThrow",
                City = "ShouldThrow",
            };
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService.EditAddress(viewModel,UserConstants.AdminId));
            viewModel.Street = "ShouldThrow 123";
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService.EditAddress(viewModel, Guid.NewGuid().ToString()));
            viewModel.Street = "Should not throw 123";
            viewModel.City = "Should not throw City";
            viewModel.AddressId = address.Id;
            Assert.ThrowsAsync<ApplicationException>(async () => await _addressService.EditAddress(viewModel, Guid.NewGuid().ToString()));
            Assert.DoesNotThrowAsync(async () => await _addressService.EditAddress(viewModel,UserConstants.AdminId));
            Assert.That(_dataProtectionService!.Decrypt(address.City),Is.EqualTo(viewModel.City));
            Assert.That(_dataProtectionService!.Decrypt(address.Street), Is.EqualTo(viewModel.Street));
        }
    }
}
