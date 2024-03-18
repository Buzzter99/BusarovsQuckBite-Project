using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;
using Microsoft.EntityFrameworkCore;
namespace BusarovsQuckBite.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IImgService _imgService;
        private readonly ICategoryService _categoryService;
        public ProductService(ApplicationDbContext context, IImgService imgService, ICategoryService categoryService)
        {
            _context = context;
            _imgService = imgService;
            _categoryService = categoryService;
        }
        public async Task<(ProductAllViewModel, int)> GetAllProductsAsync(int pageSize, int page, string? category = null, FilterEnum statusFilter = FilterEnum.All)
        {
            var categories = await _categoryService.GetCategoriesForUserByStatusAsync(FilterEnum.Active);
            var model = await _context.Products.Select(c => new ProductViewModel()
            {
                Id = c.Id,
                Name = c.Name,
                Creator = c.User.UserName,
                Description = c.Description,
                Price = c.Price,
                QtyAvailable = c.Quantity,
                ImageRelativePath = c.Img.RelativePath + c.Img.Name,
                Category = new CategoryViewModel()
                {
                    Id = c.Category.Id,
                    Name = c.Category.Name,
                },
                CreatedOn = c.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat),
                IsDeleted = c.IsDeleted,
            }).ToListAsync();
            if (category != null)
            {
                model = model.Where(x => x.Category.Name == category).ToList();
            }
            switch (statusFilter)
            {
                case FilterEnum.Deleted:
                    model = model.Where(x => x.IsDeleted).ToList();
                    break;
                case FilterEnum.Active:
                    model = model.Where(x => !x.IsDeleted).ToList();
                    break;
            }
            int totalPages = (int)Math.Ceiling((double)(model.Count) / pageSize);
            model = model.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var result = new ProductAllViewModel()
            {
                CategoriesWithProducts = categories,
                Products = model,
                FilterOptions = EnumHelper.GetEnumSelectList<FilterEnum>()
            };
            return (result, totalPages);
        }
        public async Task AddProduct(ProductFormViewModel model, string userId)
        {
            if (model.Price <= 0)
            {
                throw new InvalidOperationException("Price Cannot be less or equal to 0!");
            }
            if (model.QtyAvailable <= 0)
            {
                throw new InvalidOperationException("Quantity Cannot be less or equal to 0!");
            }
            var category = await _categoryService.GetByIdAsync(model.CategoryId);
            if (category.IsDeleted)
            {
                throw new InvalidOperationException("Cannot add product to Deleted Category!");
            }
            model.ImageId = await _imgService.AddImg(model.ImageFile);
            var product = new Product()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Quantity = model.QtyAvailable,
                CategoryId = model.CategoryId,
                ImageId = model.ImageId,
                TransactionDateAndTime = DateTime.Now,
                IsDeleted = false,
                Who = userId
            };
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteProduct(int id)
        {
            var entity = await GetProductByIdAsync(id);
            entity.IsDeleted = !entity.IsDeleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (entity == null)
            {
                throw new InvalidOperationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return entity;
        }
    }
}
