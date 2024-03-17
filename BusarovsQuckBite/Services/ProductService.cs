using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Models;
using Microsoft.EntityFrameworkCore;

namespace BusarovsQuckBite.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProductViewModel>> GetAllProductsAsync()
        {
            return await _context.Products.Select(c => new ProductViewModel()
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
                CreatedOn = c.TransactionDateAndTime.ToString(DateFormatConstants.DefaultDateFormat)
            }).ToListAsync();
        }
    }
}
