using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.Category;
using BusarovsQuickBite.Core.Models.Enums;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Common;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository _repository;

        public CategoryService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<CategoryViewModel>> GetCategoriesForUserByStatusAsync(FilterEnum keyword)
        {
            var categories = await _repository.GetEntity<Category>()
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
            if (category.Products.Any(x => !x.IsDeleted))
            {
                throw new ApplicationException(ErrorMessagesConstants.CannotDeleteProductInCategory);
            }
            category.IsDeleted = !category.IsDeleted;
            await _repository.SaveChangesAsync();
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
            await _repository.AddAsync(category);
            await _repository.SaveChangesAsync();
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
            await _repository.SaveChangesAsync();
            return model;
        }

        public async Task<List<CategoryViewModel>> SearchByNameAsync(FilterEnum keyword, string name)
        {
            var model = _repository.GetEntity<Category>().Where(x => x.Name.ToUpper().Contains(name.ToUpper()))
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
            var category = await _repository.GetByIdAsync<Category>(id);
            if (category == null)
            {
                throw new ApplicationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return category;
        }

        public CategoryAllViewModel GetAllCategoriesForView(List<CategoryViewModel> model)
        {
            return new CategoryAllViewModel
            {
                CategoryViewModel = model,
                CategoryCriteria = EnumHelper.GetEnumSelectList<FilterEnum>()
            };
        }
    }
}
