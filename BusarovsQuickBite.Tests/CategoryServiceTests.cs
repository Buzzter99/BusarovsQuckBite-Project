using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Models.Category;
using BusarovsQuckBite.Models.Enums;
using BusarovsQuckBite.Services;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    public class CategoryServiceTests
    {
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
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
        [TearDown]
        public void TearDown()
        {
            _context!.Database.EnsureDeleted();
        }
        [Test]
        public async Task FindByIdTest()
        {
            var seededEntity = await _categoryService!.GetByIdAsync(1);
            var entityFromDb = await _context!.Categories.FirstOrDefaultAsync(x => x.Id == 1);
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetByIdAsync(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetByIdAsync(-2132));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetByIdAsync(212131));
            Assert.That(entityFromDb,Is.SameAs(seededEntity));
        }

        [Test]
        public void MapCategoryViewModelTest()
        {
            var collection = new List<CategoryViewModel>()
            {
                new()
                {
                    Id = 1,
                    Name = "test",
                    TransactionDateAndTime = DateTime.Now.ToString(DateFormatConstants.DefaultDateFormat),
                    Creator = Guid.NewGuid().ToString(),
                    IsDeleted = false
                },
                new()
                {
                    Id = 2,
                    Name = "test2",
                    TransactionDateAndTime = DateTime.Now.ToString(DateFormatConstants.DefaultDateFormat),
                    Creator = Guid.NewGuid().ToString(),
                    IsDeleted = false
                }
            };
            var enumHelp = EnumHelper.GetEnumSelectList<FilterEnum>();
            var getFromMethod = _categoryService!.GetAllCategoriesForView(collection);
            Assert.That(collection,Is.SameAs(getFromMethod.CategoryViewModel));
            Assert.That(getFromMethod.CategoryCriteria.Count, Is.EqualTo(EnumHelper.GetEnumSelectList<FilterEnum>().Count));
            Assert.That(collection.Count,Is.EqualTo(getFromMethod.CategoryViewModel.Count));
            for (int i = 0; i < enumHelp.Count; i++)
            {
                Assert.That(enumHelp[i].Value, Is.EqualTo(getFromMethod.CategoryCriteria[i].Value));
            }
        }

        [Test]
        public async Task GetCategoryMappedTest()
        {
            var category = await _categoryService!.GetCategoryMappedByIdAsync(1);
            var fromDb = await _context!.Categories.FirstOrDefaultAsync(x => x.Id == 1);
            Assert.That(category.Id,Is.EqualTo(fromDb!.Id));
            Assert.That(category.Name, Is.EqualTo(fromDb!.Name));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetCategoryMappedByIdAsync(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetCategoryMappedByIdAsync(-1));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.GetCategoryMappedByIdAsync(232131231));

        }
    }
}