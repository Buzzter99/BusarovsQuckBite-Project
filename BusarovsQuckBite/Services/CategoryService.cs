using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace BusarovsQuckBite.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(FilterEnum keyword)
        {
            var categories = await _context.Categories
                .OrderByDescending(x => x.TransactionDateAndTime).Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    TransactionDateAndTime = c.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat),
                    Creator = c.User.UserName,
                    IsDeleted = c.IsDeleted,

                }).AsNoTracking()
                .ToListAsync();
            switch (keyword)
            {
                case FilterEnum.Deleted:
                    categories = categories.Where(x => x.IsDeleted).ToList();
                    break;
                case FilterEnum.Active:
                    categories = categories.Where(x => !x.IsDeleted).ToList();
                    break;
            }
            return categories;
        }
        public async Task DeleteCategoryAsync(int id)
        {
            var category = await GetByIdAsync(id);
            if (category.Products.Any(x => !x.Category.IsDeleted))
            {
                throw new InvalidOperationException(ErrorMessagesConstants.CannotDeleteProductInCategory);
            }
            category.IsDeleted = !category.IsDeleted;
            await _context.SaveChangesAsync();
        }
        public async Task AddCategoryAsync(CategoryViewModel model, string creatorId)
        {
            var category = new Category()
            {
                Name = model.Name,
                Who = creatorId,
                IsDeleted = false,
                TransactionDateAndTime = DateTime.Now
            };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
        public async Task<CategoryViewModel> GetCategoryMappedByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            var model = new CategoryViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
            return model;
        }
        public async Task<CategoryViewModel> EditCategoryAsync(CategoryViewModel model)
        {
            var entity = await GetByIdAsync(model.Id);
            entity.Name = model.Name;
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<List<CategoryViewModel>> SearchByNameAsync(FilterEnum keyword, string name)
        {
            var model = _context.Categories.Where(x => x.Name.ToUpper().Contains(name.ToUpper()))
                .OrderByDescending(x => x.TransactionDateAndTime)
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    IsDeleted = c.IsDeleted,
                    Creator = c.User.UserName,
                    TransactionDateAndTime = c.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat)
                });
            switch (keyword)
            {
                case FilterEnum.Active:
                    model = model.Where(x => !x.IsDeleted);
                    break;
                case FilterEnum.Deleted:
                    model = model.Where(x => x.IsDeleted);
                    break;
            }
            return await model.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (category == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return category;
        }
    }
}
