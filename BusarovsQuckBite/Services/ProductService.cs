using BusarovsQuckBite.Areas.AccountManager.Models;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;

namespace BusarovsQuckBite.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IImgService _imgService;
        public ProductService(ApplicationDbContext context, IImgService imgService)
        {
            _context = context;
            _imgService = imgService;
        }
        public async Task<(List<ProductViewModel>, int)> GetAllProductsAsync(int pageSize, int page, string? category = null)
        {
            var categories = await _context.Categories.Where(x => x.Products.Any() && !x.IsDeleted).Select(b => new CategoryViewModel()
            {
                Id = b.Id,
                Name = b.Name,
            }).ToListAsync();
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
            }).ToListAsync();
            if (category != null)
            {
                model = model.Where(x => x.Category.Name == category).ToList();
            }
            int totalPages = (int)Math.Ceiling((double)(model.Count) / pageSize);
            model = model.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            if (model.Any())
            {
                model[0].CategoriesWithProducts = categories;
            }
            return (model, totalPages);
        }
        public async Task AddProduct(ProductFormViewModel model, string userId)
        {
            if (model.Price <= 0)
            {
                throw new InvalidOperationException("Price Cannot be less or equal to 0");
            }
            if (model.QtyAvailable <= 0)
            {
                throw new InvalidOperationException("Quantity Cannot be less or equal to 0");
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
    }
}
