using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Text;
using BusarovsQuickBite.Infrastructure.Data.Common;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class CartServiceTests
    {
        private IProductService? _productService;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private ICategoryService? _categoryService;
        private IImgService? _imgService;
        private Mock<IWebHostEnvironment>? _hostingEnvironmentMock;
        private ICartService? _cartService;

        [SetUp]
        public void SetUp()
        {
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _hostingEnvironmentMock = new Mock<IWebHostEnvironment>();
            _hostingEnvironmentMock.Setup(h => h.WebRootPath).Returns(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\");
            _hostingEnvironmentMock.Setup(h => h.ContentRootPath).Returns(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\");
            _imgService = new ImgService(_hostingEnvironmentMock.Object, new Repository(_context));
            _categoryService = new CategoryService(new Repository(_context));
            _productService = new ProductService(new Repository(_context), _imgService, _categoryService);
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(new Dictionary<string, string> { })
                .Build();
            var mockDataProtector = new Mock<IDataProtector>();
            mockDataProtector
                .Setup(sut => sut.Protect(It.IsAny<byte[]>()))
                .Returns<byte[]>(data =>
                { string encryptedData = Convert.ToBase64String(data); return Encoding.UTF8.GetBytes(encryptedData); });
            mockDataProtector
                .Setup(sut => sut.Unprotect(It.IsAny<byte[]>()))
                .Returns<byte[]>(data =>
                { string decryptedData = Encoding.UTF8.GetString(data); return Convert.FromBase64String(decryptedData); });
            var mockDataProtectionProvider = new Mock<IDataProtectionProvider>();
            mockDataProtectionProvider
                .Setup(s => s.CreateProtector(It.IsAny<string>())).Returns(mockDataProtector.Object);
            _cartService = new CartService(_productService, new Repository(_context));
        }
        [TearDown]
        public async Task TearDown()
        {
            await _context!.Database.EnsureDeletedAsync();
            File.Delete(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.jpg");
        }
        [Test]
        public async Task ShouldCreateCart()
        {
            var cart = await _context!.Carts.AnyAsync(x => x.Who == UserConstants.AdminId);
            Assert.IsFalse(cart);
            var createAndGetCart = await _cartService!.GetCart(UserConstants.AdminId);
            Assert.IsNotNull(createAndGetCart);
            cart = await _context!.Carts.AnyAsync(x => x.Who == UserConstants.AdminId);
            Assert.IsTrue(cart);
            var tryCreateAgain = await _cartService!.GetCart(UserConstants.AdminId);
            Assert.IsNotNull(tryCreateAgain);
            Assert.That(createAndGetCart.Id,Is.EqualTo(tryCreateAgain.Id));
            Assert.That(createAndGetCart.CartOwner,Is.EqualTo(tryCreateAgain.CartOwner));
            Assert.That(createAndGetCart.ProductAll.Count,Is.EqualTo(tryCreateAgain.ProductAll.Count));
        }
        [Test]
        public async Task GetCartForUserShouldThrow()
        {
            Assert.ThrowsAsync<ApplicationException>(async () =>
                await _cartService!.GetCartByUserId(UserConstants.AdminId));
            await _cartService!.GetCart(UserConstants.AdminId);
            Assert.DoesNotThrowAsync(async () => await _cartService!.GetCartByUserId(UserConstants.AdminId));
        }
        [Test]
        public void RemoveProductShouldThrow()
        {
            Assert.ThrowsAsync<ApplicationException>(async () =>
                await _cartService!.RemoveProductFromCart(20, UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () =>
                await _cartService!.RemoveProductFromCart(1, UserConstants.AdminId));
        }
        [Test]
        public async Task AddProductShouldThrow()
        {
            var product = await _context!.Products.FirstAsync();
            Assert.ThrowsAsync<ApplicationException>(async () => await _cartService!.AddCartProduct(0,UserConstants.AdminId));
            product.IsDeleted = true;
            await _context.SaveChangesAsync();
            Assert.ThrowsAsync<ApplicationException>(async () => await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId));
        }
        [Test]
        public async Task AddProductShouldWork()
        {
            var product = await _context!.Products.FirstAsync();
            Assert.DoesNotThrowAsync(async () => await _cartService!.AddCartProduct(product.Id,UserConstants.AdminId));
            var count = await _context!.CartProducts.CountAsync(x => x.Cart.Who == UserConstants.AdminId);
            Assert.That(count,Is.EqualTo(1));
        }
        [Test]
        public async Task AddAlreadyAddedProductShouldThrow()
        {
            var product = await _context!.Products.FirstAsync();
            Assert.DoesNotThrowAsync(async () => await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId));
        }
        [Test]
        public async Task CreateCartAndAddItemsShouldWork()
        {
            var model = await _cartService!.GetCart(UserConstants.AdminId);
            Assert.NotNull(model);
            var product = await _context!.Products.FirstAsync();
            Assert.DoesNotThrowAsync(async () => await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId));
            var count = await _context.CartProducts.CountAsync(x => x.ProductId == product.Id && x.CartId == model.Id);
            Assert.That(count,Is.EqualTo(1));
        }
        [Test]
        public async Task DeleteFromCartShouldWork()
        {
            var product = await _context!.Products.FirstAsync();
            Assert.DoesNotThrowAsync(async () => await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId));
            Assert.DoesNotThrowAsync(async () => await _cartService!.RemoveProductFromCart(product.Id, UserConstants.AdminId));
            var shouldBeEmpty = await _context.CartProducts.AnyAsync(x => x.Cart.Who == UserConstants.AdminId);
            Assert.IsFalse(shouldBeEmpty);
        }


    }
}
