using System.Text;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Enums;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Models.Address;
using BusarovsQuckBite.Models.Enums;
using BusarovsQuckBite.Models.Product;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private IProductService? _productService;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private ICategoryService? _categoryService;
        private IImgService? _imgService;
        private Mock<IFormFile>? _formFile;
        private Mock<IWebHostEnvironment>? _hostingEnvironmentMock;
        private ProductFormViewModel? _productFormViewModel;
        private IAddressService? _addressService;
        private IDataProtectionService? _dataProtectionService;

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
            _formFile = new Mock<IFormFile>();
            _formFile.Setup(f => f.Length).Returns(1024);
            _formFile.Setup(f => f.FileName).Returns("test.jpg");
            _imgService = new ImgService(_hostingEnvironmentMock.Object, _context);
            _categoryService = new CategoryService(_context);
            _productService = new ProductService(_context, _imgService, _categoryService);
            _productFormViewModel = new ProductFormViewModel
            {
                Name = "Product Name",
                Description = "Product Description",
                Price = 5,
                QtyAvailable = 10,
                CategoryId = 1,
                ImageId = 1
            };
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
            _dataProtectionService = new DataProtectionService(mockDataProtectionProvider.Object, configuration);
            _addressService = new AddressService(_context,_dataProtectionService);
        }
        [TearDown]
        public async Task TearDown()
        {
            await _context!.Database.EnsureDeletedAsync();
            File.Delete(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.jpg");
        }
        [Test]
        public async Task AddProductShouldThrow()
        {
            _productFormViewModel!.Price = 0;
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.AddProduct(_productFormViewModel, UserConstants.AdminId));
            _productFormViewModel.Price = 5;
            _productFormViewModel.QtyAvailable = 0;
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.AddProduct(_productFormViewModel, UserConstants.AdminId));
            await _categoryService!.DeleteCategoryAsync(_productFormViewModel.CategoryId);
            _productFormViewModel.QtyAvailable = 10;
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.AddProduct(_productFormViewModel, UserConstants.AdminId));
        }
        [Test]
        public async Task AddShouldWork()
        {
            int count = await _context!.Products.CountAsync();
            _productFormViewModel!.ImageFile = _formFile!.Object;
            Assert.DoesNotThrowAsync(async () => await _productService!.AddProduct(_productFormViewModel, UserConstants.AdminId));
            int afterAdd = await _context!.Products.CountAsync();
            int imgShouldBeAdded = await _context!.Img.CountAsync();
            Assert.That(count + 1, Is.EqualTo(afterAdd));
            Assert.That(count + 1, Is.EqualTo(imgShouldBeAdded));
            var getAddedItem = await _context.Products.OrderByDescending(x => x.Id).FirstAsync();
            Assert.That(_productFormViewModel.Name, Is.EqualTo(getAddedItem.Name));
            Assert.That(_productFormViewModel.Description, Is.EqualTo(getAddedItem.Description));
            Assert.That(_productFormViewModel.Price, Is.EqualTo(getAddedItem.Price));
            Assert.That(_productFormViewModel.QtyAvailable, Is.EqualTo(getAddedItem.Quantity));
            Assert.That(_productFormViewModel.CategoryId, Is.EqualTo(getAddedItem.CategoryId));
            Assert.That(_productFormViewModel.ImageId, Is.EqualTo(getAddedItem.ImageId));
            Assert.IsFalse(getAddedItem.IsDeleted);
            Assert.That(getAddedItem.Who, Is.EqualTo(UserConstants.AdminId));
        }
        [Test]
        public async Task DeleteProductShouldThrow()
        {
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.DeleteProduct(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.DeleteProduct(-1));
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.DeleteProduct(20));
            _productFormViewModel!.ImageFile = _formFile!.Object;
            await _productService!.AddProduct(_productFormViewModel, UserConstants.AdminId);
            var category = await _context!.Categories.FirstOrDefaultAsync(x => x.Id == _productFormViewModel.CategoryId);
            category!.IsDeleted = true;
            await _context.SaveChangesAsync();
            var productId = await _context!.Products.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.DeleteProduct(productId!.Id));
        }
        [Test]
        public async Task DeleteProductsShouldWork()
        {
            _productFormViewModel!.ImageFile = _formFile!.Object;
            await _productService!.AddProduct(_productFormViewModel, UserConstants.AdminId);
            var product = await _context!.Products.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            Assert.DoesNotThrowAsync(async () => await _productService.DeleteProduct(product!.Id));
            Assert.IsTrue(product!.IsDeleted);
        }
        [Test]
        public void GetByIdShouldThrow()
        {
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.GetProductByIdAsync(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.GetProductByIdAsync(-1));
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.GetProductByIdAsync(20));
        }
        [Test]
        public async Task GetByIdShouldWork()
        {
            var firstInDb = await _context!.Products.FirstAsync();
            var shouldWorkById = await _productService!.GetProductByIdAsync(firstInDb.Id);
            Assert.That(firstInDb, Is.SameAs(shouldWorkById));
        }
        [Test]
        public void MapProductShouldThrow()
        {
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.MapProductAsync(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.MapProductAsync(-1));
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.MapProductAsync(20));
        }
        [Test]
        public async Task MapProductShouldWork()
        {
            var firstInDb = await _context!.Products.FirstAsync();
            var shouldReturnActiveCategoriesCount = await _context.Categories.CountAsync(x => !x.IsDeleted);
            var viewModel = await _productService!.MapProductAsync(firstInDb.Id);
            Assert.IsNotNull(viewModel);
            Assert.That(firstInDb.Id,Is.EqualTo(viewModel.Id));
            Assert.That(firstInDb.Name, Is.EqualTo(viewModel.Name));
            Assert.That(firstInDb.Description, Is.EqualTo(viewModel.Description));
            Assert.That(firstInDb.Price, Is.EqualTo(viewModel.Price));
            Assert.That(firstInDb.Quantity, Is.EqualTo(viewModel.QtyAvailable));
            Assert.That(firstInDb.CategoryId, Is.EqualTo(viewModel.CategoryId));
            Assert.That(firstInDb.ImageId, Is.EqualTo(viewModel.ImageId));
            Assert.That(shouldReturnActiveCategoriesCount,Is.EqualTo(viewModel.ActiveCategories.Count));
        }
        [Test]
        public async Task EditProductShouldThrow()
        {
            int firstId = 1;
            var viewModelToEdit = await _productService!.MapProductAsync(firstId);
            viewModelToEdit.Price = -1;
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.EditProductAsync(viewModelToEdit));
            viewModelToEdit.Price = 20;
            viewModelToEdit.QtyAvailable = 0;
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.EditProductAsync(viewModelToEdit));
            viewModelToEdit.QtyAvailable = 5;
            var category = await _context!.Categories.FirstAsync(x => x.Id == viewModelToEdit.CategoryId);
            category.IsDeleted = true;
            await _context.SaveChangesAsync();
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.EditProductAsync(viewModelToEdit));
            category.IsDeleted = false;
            await _context.SaveChangesAsync();
            viewModelToEdit.Id = -50;
            Assert.ThrowsAsync<ApplicationException>(async () => await _productService!.EditProductAsync(viewModelToEdit));
        }
        [Test]
        public async Task EditProductShouldWork()
        {
            int firstId = 1;
            var category = await _context!.Categories.OrderByDescending(x => x.Id).FirstAsync();
            var viewModelToEdit = await _productService!.MapProductAsync(firstId);
            viewModelToEdit.Name = "Test";
            viewModelToEdit.Description = "Test Description";
            viewModelToEdit.Price = 200;
            viewModelToEdit.QtyAvailable = 123;
            viewModelToEdit.CategoryId = category.Id;
            viewModelToEdit.ImageFile = _formFile!.Object;
            Assert.DoesNotThrowAsync(async () => await _productService.EditProductAsync(viewModelToEdit));
            var entity = await _context.Products.FirstAsync(x => x.Id == firstId);
            Assert.That(entity.Id,Is.EqualTo(viewModelToEdit.Id));
            Assert.That(entity.Name, Is.EqualTo(viewModelToEdit.Name));
            Assert.That(entity.Description, Is.EqualTo(viewModelToEdit.Description));
            Assert.That(entity.Price, Is.EqualTo(viewModelToEdit.Price));
            Assert.That(entity.Quantity, Is.EqualTo(viewModelToEdit.QtyAvailable));
            Assert.That(entity.CategoryId, Is.EqualTo(viewModelToEdit.CategoryId));
            Assert.That(entity.ImageId, Is.EqualTo(viewModelToEdit.ImageId));
        }
        [Test]
        public async Task HomePageProductsShouldWork()
        {
            int count = 2;
            var expectedCount = await _context!.Products.Take(count).CountAsync(x => !x.IsDeleted && !x.Category.IsDeleted && x.Quantity > 0);
            var productsFromService = await _productService!.GetProductsForHomePageAsync(count);
            Assert.That(expectedCount,Is.EqualTo(productsFromService.Count));
            count = 10;
            var moreThanActual = await _context!.Products.CountAsync(x => !x.IsDeleted && !x.Category.IsDeleted && x.Quantity > 0);
            var productsFromServiceMoreThanInDb = await _productService!.GetProductsForHomePageAsync(count);
            Assert.That(moreThanActual,Is.EqualTo(productsFromServiceMoreThanInDb.Count));
        }
        [Test]
        public async Task SearchByTermShouldWork()
        {
            var shouldBeEmpty = await _productService!.GetAllProductsBySearchTerm("test");
            Assert.IsEmpty(shouldBeEmpty);
            var shouldReturnElement = await _productService!.GetAllProductsBySearchTerm("pIzZa");
            int expected = await _context!.Products.CountAsync(x => x.Name.ToUpper().Contains("pIzZa".ToUpper()));
            Assert.That(shouldReturnElement.Count,Is.EqualTo(expected));
        }
        [Test]
        public async Task GetProductsShouldWork()
        {
            var products = await _productService!.GetAllProductsAsync("test",FilterEnum.Active);
            var categories = await _context!.Categories.CountAsync(x => !x.IsDeleted);
            var expectedProducts = await _context!.Products.CountAsync();
            var expectedFilter = EnumHelper.GetEnumSelectList<FilterEnum>();
            Assert.That(products.CategoriesWithProducts.Count,Is.EqualTo(categories));
            Assert.That(products.Products.Count, Is.EqualTo(expectedProducts));
            Assert.That(products.FilterOptions.Count, Is.EqualTo(expectedFilter.Count));
        }
        [Test]
        public async Task GetProductsShouldWorkWithFilter()
        {
            var products = await _productService!.GetAllProductsAsync("test", FilterEnum.Deleted);
            int expectedCount = await _context!.Products.CountAsync(x => x.IsDeleted);
            Assert.That(products.Products.Count,Is.EqualTo(expectedCount));
        }
        [Test]
        public async Task ProductCategorySearchShouldWork()
        {
            var category = await _context!.Categories.FirstAsync();
            var productsFromDb = await _context.Products.CountAsync(x => x.CategoryId == category.Id);
            var products = await _productService!.GetAllProductsAsync(category.Name, FilterEnum.Active);
            Assert.That(products.Products.Count,Is.EqualTo(productsFromDb));
        }
        [Test]
        public async Task GetProductsForOrderShouldWork()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var addressId = await _context!.Addresses.FirstAsync(x => x.Who == UserConstants.AdminId);
            var product = await _context.Products.FirstAsync();
            var order = new Order
            {
                Id = 1,
                Who = UserConstants.AdminId,
                TransactionDateAndTime = DateTime.Now,
                Status = OrderStatus.Processing,
                TotalAmount = product.Price,
                PaymentType = PaymentType.Cash,
                AddressId = addressId.Id,
            };
            var orderProducts = new OrderProduct()
            {
                OrderId = order.Id,
                ProductId = product.Id,
                QtyOrdered = 1
            };
            await _context.Orders.AddAsync(order);
            await _context.OrdersProducts.AddAsync(orderProducts);
            await _context.SaveChangesAsync();
            var shouldBeEmpty = await _productService!.GetProductsForOrderAsync(order.Id + 1);
            Assert.IsEmpty(shouldBeEmpty);
            var shouldReturnOrderedProduct = await _productService!.GetProductsForOrderAsync(order.Id);
            var countFromDb = await _context.OrdersProducts.CountAsync(x => x.OrderId == order.Id);
            Assert.That(shouldReturnOrderedProduct.Count,Is.EqualTo(countFromDb));
        }
    }
}
