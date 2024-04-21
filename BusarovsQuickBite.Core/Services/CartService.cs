using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Cart;
using BusarovsQuckBite.Models.Category;
using BusarovsQuckBite.Models.Product;
using BusarovsQuickBite.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuckBite.Services
{
    public class CartService : ICartService
    {
        private readonly IProductService _productService;
        private readonly IRepository _repository;

        public CartService(IProductService productService, IRepository repository)
        {
            _productService = productService;
            _repository = repository;
        }
        public async Task<CartViewModel> GetCart(string userId)
        {
            CartViewModel model = new CartViewModel
            {
                CartOwner = userId
            };
            if (!await IsCartCreatedAsync(userId))
            {
                int id = await CreateCartAsync(userId);
                model.Id = id;
            }
            else
            {
                var cart = await _repository.GetEntity<Cart>().FirstAsync(x => x.Who == userId);
                model.Id = cart.Id;
            }
            model.ProductAll = await FindProductsForUserAndCart(userId);
            return model;
        }

        public async Task<List<ProductViewModel>> FindProductsForUserAndCart(string userId)
        {
            return await _repository.GetEntity<CartProduct>().Where(x => x.Cart.Who == userId)
                .Select(c => new ProductViewModel
                {
                    Id = c.Product.Id,
                    Name = c.Product.Name,
                    Description = c.Product.Description,
                    Price = c.Product.Price,
                    QtyAvailable = c.Product.Quantity,
                    Category = new CategoryViewModel()
                    {
                        Id = c.Product.Category.Id,
                        Name = c.Product.Category.Name,
                    },
                    ImageRelativePath = c.Product.Img.RelativePath + c.Product.Img.Name
                })
                .ToListAsync();
        }
        public async Task AddCartProduct(int productId, string userId)
        {
            var product = await _productService.GetProductByIdAsync(productId);
            if (product.IsDeleted)
            {
                throw new ApplicationException("You are trying to add deleted product!");
            }
            if (await IsCartCreatedAsync(userId))
            {
                var cart = await GetCart(userId);
                if (cart.ProductAll.Any(x => x.Id == product.Id))
                {
                    throw new ApplicationException("Product already Added!");
                }
                await _repository.AddAsync(new CartProduct()
                {
                    CartId = cart.Id,
                    ProductId = product.Id
                });
            }
            else
            {
                var cartId = await CreateCartAsync(userId);
                await _repository.AddAsync(new CartProduct()
                {
                    CartId = cartId,
                    ProductId = productId
                });
            }
            await _repository.SaveChangesAsync();
        }
        public async Task RemoveProductFromCart(int productId,string userId)
        {
            var product = await _repository.GetEntity<CartProduct>().FirstOrDefaultAsync(x => x.ProductId == productId && x.Cart.Who == userId);
            if (product == null)
            {
                throw new ApplicationException(ErrorMessagesConstants.EntityNotFoundExceptionMessage);
            }
            _repository.DeleteEntity(product);
            await _repository.SaveChangesAsync();
        }
        public async Task<Cart> GetCartByUserId(string userId)
        {
            var cart = await _repository.GetEntity<Cart>().FirstOrDefaultAsync(x => x.Who == userId);
            if (cart == null)
            {
                throw new ApplicationException("Cart not found");
            }
            return cart;
        }

        private async Task<bool> IsCartCreatedAsync(string userId)
        {
            return await _repository.GetEntity<Cart>().FirstOrDefaultAsync(x => x.Who == userId) != null;
        }
        private async Task<int> CreateCartAsync(string userId)
        {
            var cart = new Cart
            {
                TransactionDateAndTime = DateTime.Now,
                Who = userId
            };
            await _repository.AddAsync(cart);
            await _repository.SaveChangesAsync();
            return cart.Id;
        }
    }
}
