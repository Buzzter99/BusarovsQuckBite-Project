using BusarovsQuickBite.Infrastructure.Data;
using BusarovsQuickBite.Infrastructure.Data.Common;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BusarovsQuickBite.Tests
{
    public class RepositoryTests
    {
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private IRepository? _repository;
        [SetUp]
        public void Setup()
        {
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _repository = new Repository(_context);
        }
        [TearDown]
        public void TearDown()
        {
            _context!.Database.EnsureDeleted();
        }

        [Test]
        public void GetEntityShouldReturnEntity()
        {
            var product = _repository!.GetEntity<Product>();
            var category = _repository!.GetEntity<Category>();
            var address = _repository!.GetEntity<Address>();
            Assert.IsInstanceOf<DbSet<Product>>(product);
            Assert.IsInstanceOf<DbSet<Category>>(category);
            Assert.IsInstanceOf<DbSet<Address>>(address);
        }

        [Test]
        public void ShouldReturnAll()
        {
            var all = _repository!.All<Product>();
            var expectedCount = _context!.Products.Count();
            Assert.IsInstanceOf<IQueryable<Product>>(all);
            Assert.That(expectedCount,Is.EqualTo(all.Count()));
        }
        [Test]
        public void ShouldReturnAllReadOnly()
        {
            var all = _repository!.AllReadOnly<Category>();
            var expectedCount = _context!.Categories.Count();
            Assert.IsInstanceOf<IQueryable<Category>>(all);
            Assert.That(expectedCount, Is.EqualTo(all.Count()));
        }
        [Test]
        public async Task AddAsyncShouldWork()
        {
            var address = new Address()
            {
                City = "Test",
                Street = "Test 123",
                IsDeleted = false
            };
            await _repository!.AddAsync(address);
            var expectedCount = await _context!.Addresses.CountAsync();
            var actual = _repository.All<Address>().Count();
            Assert.That(expectedCount,Is.EqualTo(actual));
            await _repository.SaveChangesAsync();
            Assert.That(expectedCount, Is.EqualTo(actual));
        }
        [Test]
        public async Task GetByIdShouldWork()
        {
            Assert.IsNotNull(await _repository!.GetByIdAsync<Product>(1));
            Assert.IsNull(await _repository!.GetByIdAsync<Product>(4));
        }
        [Test]
        public async Task DeleteShouldWork()
        {
            var shouldDelete = await _repository!.GetByIdAsync<Product>(1);
            _repository.DeleteEntity(shouldDelete);
            await _repository!.SaveChangesAsync();
            var expected = await _context!.Products.CountAsync();
            var actual = _repository.All<Product>().Count();
            Assert.That(expected,Is.EqualTo(actual));
            Product nullEntity = null;
            _repository.DeleteEntity(nullEntity);
            await _repository!.SaveChangesAsync();
            var expectedNotDeleted = _repository.All<Product>().Count();
            var actualShouldRemainUnchanged = _context.Products.Count();
            Assert.That(expectedNotDeleted, Is.EqualTo(actualShouldRemainUnchanged));
        }
    }
}
