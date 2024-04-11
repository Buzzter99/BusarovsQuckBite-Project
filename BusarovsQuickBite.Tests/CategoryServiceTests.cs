using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
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
        private ICategoryService? _categoryService;
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
        [Test]
        public async Task AddCategoryTest()
        {
            string expectedName = "TestCategoryAdd";
            await _categoryService!.AddCategoryAsync(new CategoryViewModel
            {
                Name = expectedName
            },UserConstants.AdminId);
            var find = await _categoryService.GetByIdAsync(8);
            var sameInMemory = await _context!.Categories.FirstAsync(x => x.Id == 8);
            Assert.IsNotNull(find);
            Assert.That(find.Name, Is.EqualTo(expectedName));
            Assert.That(find.Who, Is.EqualTo(UserConstants.AdminId));
            Assert.IsFalse(find.IsDeleted);
            Assert.That(find.Id,Is.EqualTo(8));
            Assert.That(find,Is.SameAs(sameInMemory));
        }

        [Test]
        public async Task EditCategoryTest()
        {
            string editedCategoryName = "Edited Category!";
            var dbEntity = await _context!.Categories.FirstAsync(x => x.Id == 1);
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.EditCategoryAsync(new CategoryViewModel() { Id = -1 }));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.EditCategoryAsync(new CategoryViewModel() { Id = 0 }));
            var entity = await _categoryService!.EditCategoryAsync(new CategoryViewModel 
            {
                Id = 1,
                Name = editedCategoryName,
            });
            Assert.That(entity.Name,Is.EqualTo(editedCategoryName));
            Assert.That(entity.Id,Is.EqualTo(dbEntity.Id));
        }
        [Test]
        public async Task SoftDeleteCategoryTest()
        {
            var entityToDelete = await _context!.Categories.FirstOrDefaultAsync(x => x.Id == 1);
            var model1 = _context!.Categories
                .Include(c => c.Products)
                .FirstOrDefault(c => c.Id == 4);
            var model2 = _context!.Categories
                .Include(c => c.Products)
                .FirstOrDefault(c => c.Id == 3);
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.DeleteCategoryAsync(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.DeleteCategoryAsync(-1));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.DeleteCategoryAsync(model1!.Id));
            Assert.ThrowsAsync<ApplicationException>(async () => await _categoryService!.DeleteCategoryAsync(model2!.Id));
            await _categoryService!.DeleteCategoryAsync(entityToDelete!.Id);
            Assert.IsTrue(entityToDelete.IsDeleted);
            await _categoryService!.DeleteCategoryAsync(entityToDelete!.Id);
            Assert.IsFalse(entityToDelete.IsDeleted);
        }

        [Test]
        public async Task GetCategoriesForUserByStatusTest()
        {
            int expectedCount =await _context!.Categories.CountAsync();
            var collection = await _categoryService!.GetCategoriesForUserByStatusAsync(FilterEnum.All);
            Assert.That(collection.Count,Is.EqualTo(expectedCount));
            collection = await _categoryService!.GetCategoriesForUserByStatusAsync(FilterEnum.Active);
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            collection = await _categoryService!.GetCategoriesForUserByStatusAsync(FilterEnum.Deleted);
            Assert.That(collection.Count, Is.EqualTo(0));
            await _categoryService.DeleteCategoryAsync(1);
            int expectedAfterDelete = expectedCount - 1;
            collection = await _categoryService!.GetCategoriesForUserByStatusAsync(FilterEnum.Active);
            Assert.That(collection.Count, Is.EqualTo(expectedAfterDelete));
            collection = await _categoryService!.GetCategoriesForUserByStatusAsync(FilterEnum.All);
            Assert.That(collection.Count, Is.EqualTo(expectedCount));
            collection = await _categoryService!.GetCategoriesForUserByStatusAsync(FilterEnum.Deleted);
            Assert.That(collection.Count, Is.EqualTo(expectedCount - expectedAfterDelete));
        }
        [Test]
        public async Task SearchByNameTest()
        {
            string searchTerm = "pIzZa";
            int expected = _context!.Categories.Count(x => x.Name.ToUpper().Contains(searchTerm.ToUpper()));
            var categories = await _categoryService!.SearchByNameAsync(FilterEnum.All, searchTerm);
            Assert.That(categories.Count,Is.EqualTo(expected));
            categories = await _categoryService!.SearchByNameAsync(FilterEnum.Active, searchTerm);
            Assert.That(categories.Count,Is.EqualTo(expected));
            categories = await _categoryService!.SearchByNameAsync(FilterEnum.Deleted, searchTerm);
            Assert.That(categories.Count, Is.EqualTo(0));
            categories = await _categoryService!.SearchByNameAsync(FilterEnum.All, "non-existing");
            Assert.That(categories.Count, Is.EqualTo(0));
            categories = await _categoryService!.SearchByNameAsync(FilterEnum.Active, "non-existing");
            Assert.That(categories.Count, Is.EqualTo(0));
            categories = await _categoryService!.SearchByNameAsync(FilterEnum.Deleted, "non-existing");
            Assert.That(categories.Count, Is.EqualTo(0));

        }
    }
}