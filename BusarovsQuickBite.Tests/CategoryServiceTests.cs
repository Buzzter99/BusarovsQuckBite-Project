using BusarovsQuckBite.Data;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    public class Tests
    {
        private DbContextOptions<ApplicationDbContext> _dbOptions;
        private ApplicationDbContext? _context;
        private CategoryService? _categoryService;
        [SetUp]
        public void Setup()
        {
            // var mockManager = new Mock<ApplicationUserManager<ApplicationUser>>();
            // var test = mockManager.Setup(x => x.CreateAsync(new ApplicationUser()))
            //     .ReturnsAsync(IdentityResult.Failed());
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _categoryService = new CategoryService(_context);
        }
        [Test]
        public void CreateCategory()
        {
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetByIdAsync(0));
        }

        [TearDown]
        public void TearDown()
        {
            _context!.Database.EnsureDeleted();
        }
    }
}