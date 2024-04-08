using BusarovsQuckBite.Data;
using BusarovsQuckBite.Services;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    public class CategoryServiceTests
    {
        private DbContextOptions<ApplicationDbContext> _dbOptions;
        private ApplicationDbContext? _context;
        private CategoryService? _categoryService;
        [SetUp]
        public void Setup()
        {
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _categoryService = new CategoryService(_context);
        }
        [Test]
        public void FindByNonExistingIdShouldThrow()
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