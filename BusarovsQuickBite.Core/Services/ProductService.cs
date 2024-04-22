using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Models.Category;
using BusarovsQuickBite.Core.Models.Enums;
using BusarovsQuickBite.Core.Models.Product;
using BusarovsQuickBite.Infrastructure.Constants;
using BusarovsQuickBite.Infrastructure.Data.Common;
using BusarovsQuickBite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;
namespace BusarovsQuickBite.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository _repository;
        private readonly IImgService _imgService;
        private readonly ICategoryService _categoryService;
        public ProductService(IRepository repository, IImgService imgService, ICategoryService categoryService)
        {
            _repository = repository;
            _imgService = imgService;
            _categoryService = categoryService;
        }
        public async Task<ProductAllViewModel> GetAllProductsAsync(string? category = null, FilterEnum statusFilter = FilterEnum.All)
        {
            var categories = await _categoryService.GetCategoriesForUserByStatusAsync(FilterEnum.Active);
            var model = _repository.AllReadOnly<Product>().Select(c => new ProductViewModel()
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
            if (category != null && categories.Any(x => x.Name.ToUpper() == category.ToUpper()))
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
            return result;
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
            await _repository.AddAsync(product);
            await _repository.SaveChangesAsync();
        }
        public async Task DeleteProduct(int id)
        {
            var entity = await GetProductByIdAsync(id);
            if (entity.Category.IsDeleted)
            {
                throw new ApplicationException("Cannot Modify Product to Deleted Category!");
            }
            entity.IsDeleted = !entity.IsDeleted;
            await _repository.SaveChangesAsync();
        }
        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var entity = await _repository.GetByIdAsync<Product>(productId);
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
            await _repository.SaveChangesAsync();
            await _imgService.DeleteUnusedImages();
        }
        public async Task<List<ProductViewModel>> GetProductsForHomePageAsync(int count)
        {
            var model = await _repository.AllReadOnly<Product>().Where(x => !x.IsDeleted && !x.Category.IsDeleted 
                                                                        && x.Quantity > 0)
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
        public async Task<List<ProductViewModel>> GetAllProductsBySearchTerm(string searchTerm = "")
        {
            ProductViewModel model = new ProductViewModel();
            var entity = await _repository.AllReadOnly<Product>().Where(x => (!x.IsDeleted && !x.Category.IsDeleted) && (x.Name.ToUpper().Contains(searchTerm.ToUpper())
                                                      || x.Category.Name.Contains(searchTerm.ToUpper())
                                                      || x.Description.ToUpper().Contains(searchTerm.ToUpper())))
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
            return entity;
        }
        public async Task<List<ProductViewModel>> GetProductsForOrderAsync(int orderId)
        {
            return await _repository.AllReadOnly<OrderProduct>().Where(x => x.OrderId == orderId).Select(c => new ProductViewModel
            {
                Id = c.ProductId,
                Name = c.Product.Name,
                Description = c.Product.Description,
                Price = c.Product.Price,
                Category = new CategoryViewModel
                {
                    Id = c.Product.CategoryId,
                    Name = c.Product.Category.Name,
                },
                QtyWanted = c.QtyOrdered,
                ImageRelativePath = c.Product.Img.RelativePath + c.Product.Img.Name,
            }).ToListAsync();
        }
    }
}
