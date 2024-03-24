using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using BusarovsQuckBite.Models.Enums;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;
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
            var model = _context.Products.Select(c => new ProductViewModel()
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
            });
            if (category != null)
            {
                model = model.Where(x => x.Category.Name == category);
            }
            switch (statusFilter)
            {
                case FilterEnum.Deleted:
                    model = model.Where(x => x.IsDeleted);
                    break;
                case FilterEnum.Active:
                    model = model.Where(x => !x.IsDeleted);
                    break;
            }
            var result = new ProductAllViewModel()
            {
                CategoriesWithProducts = categories,
                Products = await model.ToListAsync(),
                FilterOptions = EnumHelper.GetEnumSelectList<FilterEnum>()
            };
            int totalPages = (int)Math.Ceiling((double)(result.Products.Count) / pageSize);
            result.Products = result.Products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return (result, totalPages);
        }
        public async Task AddProduct(ProductFormViewModel model, string userId)
        {
            if (model.Price <= 0)
            {
                throw new ApplicationException("Price Cannot be less or equal to 0!");
            }
            if (model.QtyAvailable <= 0)
            {
                throw new ApplicationException("Quantity Cannot be less or equal to 0!");
            }
            var category = await _categoryService.GetByIdAsync(model.CategoryId);
            if (category.IsDeleted)
            {
                throw new ApplicationException("Cannot add product to Deleted Category!");
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
                throw new ApplicationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            return entity;
        }

        public async Task<ProductFormViewModel> MapProductAsync(int id)
        {
            var product = await GetProductByIdAsync(id);
            var model = new ProductFormViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                QtyAvailable = product.Quantity,
                CategoryId = product.CategoryId,
                ActiveCategories = await _categoryService.GetCategoriesForUserByStatusAsync(FilterEnum.Active),
                ImageId = product.ImageId,
            };
            return model;
        }
        public async Task EditProductAsync(ProductFormViewModel model)
        {
            if (model.Price <= 0)
            {
                throw new ApplicationException("Price Cannot be less or equal to 0!");
            }
            if (model.QtyAvailable <= 0)
            {
                throw new ApplicationException("Quantity Cannot be less or equal to 0!");
            }
            var category = await _categoryService.GetByIdAsync(model.CategoryId);
            if (category.IsDeleted)
            {
                throw new ApplicationException("Cannot add product to Deleted Category!");
            }
            var entity = await GetProductByIdAsync(model.Id);
            model.ImageId = await _imgService.AddImg(model.ImageFile);
            entity.Name = model.Name;
            entity.Description = model.Description;
            entity.Price = model.Price;
            entity.Quantity = model.QtyAvailable;
            entity.CategoryId = model.CategoryId;
            entity.ImageId = model.ImageId;
            await _context.SaveChangesAsync();
            await _imgService.DeleteUnusedImages();
        }
        public async Task<List<ProductViewModel>> GetProductsForHomePageAsync(int count)
        {
            var model = await _context.Products.Where(x => !x.IsDeleted && x.Quantity > 0)
                .OrderBy(x => x.Price)
                .ThenByDescending(x => x.TransactionDateAndTime).Take(count).Select(c => new ProductViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Price = c.Price,
                    QtyAvailable = c.Quantity,
                    ImageRelativePath = c.Img.RelativePath + c.Img.Name,
                    Category = new CategoryViewModel()
                    {
                        Name = c.Category.Name,
                    },
                }).ToListAsync();
            return model;
        }
        public async Task<List<ProductViewModel>> GetProductsForHomePageAsync()
        {
            var model = await _context.Products.Where(x => !x.IsDeleted && x.Quantity > 0)
                .OrderBy(x => x.Price)
                .ThenByDescending(x => x.TransactionDateAndTime).Select(c => new ProductViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Price = c.Price,
                    QtyAvailable = c.Quantity,
                    ImageRelativePath = c.Img.RelativePath + c.Img.Name,
                    Category = new CategoryViewModel()
                    {
                        Name = c.Category.Name,
                    },
                }).ToListAsync();
            return model;
        }

        public async Task<ProductAllViewModel> GetAllProductsBySearchTerm(string searchTerm)
        {
            ProductAllViewModel model = new ProductAllViewModel();
            var entity = await _context.Products.Where(x => x.Name.ToUpper().Contains(searchTerm.ToUpper())
                                                      || x.Category.Name.Contains(searchTerm.ToUpper())
                                                      || x.Description.ToUpper().Contains(searchTerm.ToUpper()))
                .Select(c => new ProductViewModel()
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
            model.Products = entity;
            return model;
        }
    }
}
