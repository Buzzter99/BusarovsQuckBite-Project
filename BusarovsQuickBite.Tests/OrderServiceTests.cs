using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Text;
using BusarovsQuckBite.Constants;
using BusarovsQuckBite.Data.Enums;
using BusarovsQuckBite.Models.Address;
using BusarovsQuckBite.Models.Cart;
using BusarovsQuckBite.Models.Enums;
using BusarovsQuckBite.Models.Order;
using BusarovsQuckBite.Models.Product;
using BusarovsQuickBite.Infrastructure.Data.Common;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private IImgService? _imgService;
        private Mock<IWebHostEnvironment>? _hostingEnvironmentMock;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private ICartService? _cartService;
        private IProductService? _productService;
        private ICategoryService? _categoryService;
        private IOrderService? _orderService;
        private IAddressService? _addressService;
        private ApplicationUserManager<ApplicationUser>? _userManager;
        private UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
            IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>, IdentityRoleClaim<string>>? _store;
        private IDataProtectionService? _dataProtectionService;
        private RoleManager<ApplicationRole>? _roleManager;
        [SetUp]
        public void Setup()
        {
            
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
            _cartService = new CartService(_productService, new Repository(_context));
            _addressService = new AddressService(new Repository(_context), _dataProtectionService);
            _store = new UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, string, IdentityUserClaim<string>,
                IdentityUserRole<string>, IdentityUserLogin<string>, IdentityUserToken<string>,
                IdentityRoleClaim<string>>(_context);
            _userManager = new ApplicationUserManager<ApplicationUser>(_store,
                null, new PasswordHasher<ApplicationUser>(), null, null, null, null, null, null, _dataProtectionService);
            _roleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole, ApplicationDbContext>(_context),null,null,null,null);
            _orderService = new OrderService(_cartService,_addressService,new Repository(_context),_productService,_userManager);
        }
        [TearDown]
        public async Task TearDown()
        {
            await _context!.Database.EnsureDeletedAsync();
            File.Delete(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.jpg");
        }
        [Test]
        public void GetByIdShouldThrow()
        {
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.GetByIdAsync(20));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.GetByIdAsync(0));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.GetByIdAsync(-20));
        }
        [Test]
        public void EmptyCartShouldThrow()
        {
            var model = new OrderViewModel { Cart = new CartViewModel {ProductAll = new List<ProductViewModel>()}};
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.ValidateOrderAsync(model,UserConstants.AdminId));
        }
        [Test]
        public async Task CartsAreNotEqualShouldThrow()
        {
            var model = new OrderViewModel { Cart = new CartViewModel { ProductAll = new List<ProductViewModel>()
            {
                new ProductViewModel
                {
                    Id = 20,
                    QtyWanted = 5
                }
            } } };
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id,UserConstants.AdminId);
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.ValidateOrderAsync(model, UserConstants.AdminId));
        }
        [Test]
        public async Task QtyWantedIsEqualToZero()
        {
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = 0
                        }
                    }
                }
            };
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.ValidateOrderAsync(model, UserConstants.AdminId));
        }
        [Test]
        public async Task QtyWantedIsLessThanZero()
        {
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = -20
                        }
                    }
                }
            };
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.ValidateOrderAsync(model, UserConstants.AdminId));
        }
        [Test]
        public async Task QtyWantedIsMoreThanAvailableShouldThrow()
        {
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity + 1
                        }
                    }
                }
            };
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.ValidateOrderAsync(model, UserConstants.AdminId));
        }
        [Test]
        public async Task ValidateOrderShouldWork()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    }
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var shouldWork = await _orderService!.ValidateOrderAsync(model, UserConstants.AdminId);
            var cartShouldContainCorrectItem = shouldWork.Cart.ProductAll.FirstOrDefault(c => c.Id == product.Id);
            Assert.That(shouldWork.Cart.CartOwner,Is.EqualTo(UserConstants.AdminId));
            Assert.IsNotNull(cartShouldContainCorrectItem);
            var getPaymentTypes = EnumHelper.GetEnumSelectList<PaymentType>();
            Assert.That(getPaymentTypes.Count,Is.EqualTo(shouldWork.PaymentType.Count));
            var getActiveAddresses = await _context.Addresses.Where(x => !x.IsDeleted && x.Who == UserConstants.AdminId).ToListAsync();
            Assert.That(shouldWork.Addresses.Count,Is.EqualTo(getActiveAddresses.Count));
            Assert.That(shouldWork.SelectedAddressId,Is.EqualTo(model.SelectedAddressId));
            Assert.That(shouldWork.PaymentTypeValue,Is.EqualTo(model.PaymentTypeValue));
        }

        [Test]
        public void PlaceOrderShouldThrowInvalidOwner()
        {
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    CartOwner = Guid.NewGuid().ToString(),
                },
            };
            Assert.ThrowsAsync<ApplicationException>(async () =>
                await _orderService!.PlaceOrder(model, UserConstants.AdminId));
        }
        [Test]
        public async Task PlaceOrderShouldThrowInvalidPaymentType()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = "Test"
            };
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.PlaceOrder(model,UserConstants.AdminId));
        }
        [Test]
        public async Task PlaceOrderShouldReturnCorrectId()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            int initialQty = product.Quantity;
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            Assert.NotNull(orderId);
            var getOrder = await _context.Orders.FirstAsync(x => x.Id == orderId);
            Assert.NotNull(getOrder);
            Assert.That(getOrder.Who,Is.EqualTo(model.Cart.CartOwner));
            Assert.That(getOrder.Status.ToString(),Is.EqualTo(OrderStatus.Processing.ToString()));
            Assert.That(getOrder.PaymentType.ToString(),Is.EqualTo(model.PaymentTypeValue));
            Assert.That(getOrder.AddressId,Is.EqualTo(model.SelectedAddressId));
            var cartShouldExist = await _context.Carts.FirstAsync(x => x.Who == UserConstants.AdminId);
            Assert.IsNotNull(cartShouldExist);
            var cartProductsShouldBeEmpty = await _context.CartProducts.Where(x => x.Cart.Who == UserConstants.AdminId).ToListAsync();
            Assert.IsEmpty(cartProductsShouldBeEmpty);
            var orderProductsShouldWork = await _context.OrdersProducts.Where(x => x.OrderId == orderId).ToListAsync();
            Assert.IsNotNull(orderProductsShouldWork);
            Assert.That(orderProductsShouldWork.Count,Is.EqualTo(1));
            Assert.That(getOrder.TotalAmount,Is.EqualTo(product.Price * product.Quantity));
            Assert.That(product.Quantity,Is.EqualTo(0));
            var orderProduct = await _context.OrdersProducts.FirstAsync(x => x.OrderId == orderId && x.ProductId == product.Id);
            Assert.That(orderProduct.QtyOrdered,Is.EqualTo(initialQty));
        }

        [Test]
        public async Task OrderShouldThrowInvalidCartItem()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = 20,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.PlaceOrder(model,UserConstants.AdminId));
        }

        [Test]
        public async Task GetOrderStatusShouldThrow()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.GetOrderStatusAsync(20,UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.GetOrderStatusAsync(0,UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService!.GetOrderStatusAsync(-20, UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService.GetOrderStatusAsync(orderId,Guid.NewGuid().ToString()));
        }
        [Test]
        public async Task GetOrderStatusShouldWork()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            Assert.NotNull(orderId);
            var status = await _orderService.GetOrderStatusAsync(orderId, UserConstants.AdminId);
            Assert.That(status,Is.EqualTo(0));
        }
        [Test]
        public async Task GetOrdersForUserShouldReturnUserMadeOrders()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity - 1
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            var countForUser = await _context.Orders.CountAsync(x => x.Who == UserConstants.AdminId);
            Assert.That(countForUser,Is.EqualTo(2));

            var appUser = new ApplicationUser()
            {
                UserName = "Test",
                Email = "Test@test.bg",
                PhoneNumber = "0878450899"
            };
            await _userManager!.CreateAsync(appUser, "000000");
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, appUser.Id);
            var addressForSecondUser = await _context!.Addresses.FirstAsync(c => c.Who == appUser.Id);
            var productForSecondUser = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(productForSecondUser.Id,appUser.Id);
            var modelForSecondUser = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>
                    {
                        new()
                        {
                            Id = productForSecondUser.Id,
                            QtyWanted = productForSecondUser.Quantity - 1
                        }
                    },
                    CartOwner = appUser.Id
                },
                SelectedAddressId = addressForSecondUser.Id,
                Addresses = new List<AddressViewModel>
                {
                    new ()
                    {
                        AddressId = addressForSecondUser.Id,
                        Street = addressForSecondUser.Street,
                        City = addressForSecondUser.City,
                        IsDeleted = addressForSecondUser.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            await _orderService!.PlaceOrder(modelForSecondUser, appUser.Id);
            await _cartService!.AddCartProduct(productForSecondUser.Id, appUser.Id);
            var countForSecondUser = await _context.Orders.CountAsync(x => x.Who == appUser.Id);
            var orderForFirstUser = await _orderService.GetOrdersForUser(UserConstants.AdminId);
            var orderForSecondUser = await _orderService.GetOrdersForUser(appUser.Id);
            Assert.That(countForUser, Is.EqualTo(orderForFirstUser.OrderModel.Count));
            Assert.That(countForSecondUser,Is.EqualTo(orderForSecondUser.OrderModel.Count));
            var totalOrders = await _context.Orders.CountAsync();
            var totalOrderModel = await _orderService.GetAllOrders();
            Assert.That(totalOrders,Is.EqualTo(totalOrderModel.OrderModel.Count));
            var helper = EnumHelper.GetEnumSelectList<OrderStatus>();
            Assert.That(helper.Count,Is.EqualTo(totalOrderModel.OrderStatuses.Count));
        }
        [Test]
        public async Task UpadeOrderStatusShouldThrow()
        {
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService.UpdateOrderStatus(-10,UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService.UpdateOrderStatus(-0, UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService.UpdateOrderStatus(20, UserConstants.AdminId));
            Assert.ThrowsAsync<ApplicationException>(async () => await _orderService.UpdateOrderStatus(orderId, UserConstants.AdminId));
        }
        [Test]
        public async Task UpadeOrderStatusShouldWork()
        {
            var cook = new ApplicationUser()
            {
                UserName = "cook",
                Email = "cook@test.bg",
                PhoneNumber = "1234567890"
            };
            var driver = new ApplicationUser()
            {
                UserName = "driver",
                Email = "driver@test.bg",
                PhoneNumber = "1234567891"
            };
            var customer = new ApplicationUser()
            {
                UserName = "customer",
                Email = "customer@test.bg",
                PhoneNumber = "1234567892"
            };
            var adminUser = new ApplicationUser()
            {
                UserName = "administrator",
                Email = "administrator@test.bg",
                PhoneNumber = "1234567893"
            };
            await _userManager!.CreateAsync(cook,"000000");
            await _userManager!.CreateAsync(adminUser, "000000");
            await _userManager.CreateAsync(driver, "000000");
            await _userManager.CreateAsync(customer, "000000");
            await _roleManager!.CreateAsync(new () { Name = RoleConstants.CookingStaffRoleName });
            await _roleManager!.CreateAsync(new () { Name = RoleConstants.DeliveryDriverRoleName });
            await _roleManager!.CreateAsync(new () { Name = RoleConstants.CustomerRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.AdminRoleName });
            await _userManager.AddToRoleAsync(cook, RoleConstants.CookingStaffRoleName);
            await _userManager.AddToRoleAsync(driver, RoleConstants.DeliveryDriverRoleName);
            await _userManager.AddToRoleAsync(customer, RoleConstants.CustomerRoleName);
            await _userManager.AddToRoleAsync(adminUser, RoleConstants.AdminRoleName);
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            var order = await _orderService!.GetByIdAsync(orderId);
            await _orderService.UpdateOrderStatus(order.Id,driver.Id);
            await _orderService.UpdateOrderStatus(order.Id, customer.Id);
            await _orderService.UpdateOrderStatus(order.Id, adminUser.Id);
            Assert.That(order.Status.ToString(),Is.EqualTo(OrderStatus.Processing.ToString()));
            await _orderService.UpdateOrderStatus(order.Id, cook.Id);
            Assert.That(order.Status.ToString() == OrderStatus.Preparing.ToString());
            await _orderService.UpdateOrderStatus(order.Id, cook.Id);
            Assert.That(order.Status.ToString() == OrderStatus.ReadyForDelivery.ToString());
            await _orderService.UpdateOrderStatus(order.Id, cook.Id);
            await _orderService.UpdateOrderStatus(order.Id, adminUser.Id);
            await _orderService.UpdateOrderStatus(order.Id, customer.Id);
            Assert.That(order.Status.ToString() == OrderStatus.ReadyForDelivery.ToString());
            await _orderService.UpdateOrderStatus(order.Id, driver.Id);
            Assert.That(order.Status.ToString() == OrderStatus.OnTheWay.ToString());
            await _orderService.UpdateOrderStatus(order.Id, driver.Id);
            Assert.That(order.Status.ToString() == OrderStatus.Delivered.ToString());
        }
        [Test]
        public async Task CountShouldBeCorrect()
        {
            var cook = new ApplicationUser()
            {
                UserName = "cook",
                Email = "cook@test.bg",
                PhoneNumber = "1234567890"
            };
            var driver = new ApplicationUser()
            {
                UserName = "driver",
                Email = "driver@test.bg",
                PhoneNumber = "1234567891"
            };
            var customer = new ApplicationUser()
            {
                UserName = "customer",
                Email = "customer@test.bg",
                PhoneNumber = "1234567892"
            };
            var adminUser = new ApplicationUser()
            {
                UserName = "administrator",
                Email = "administrator@test.bg",
                PhoneNumber = "1234567893"
            };
            await _userManager!.CreateAsync(cook, "000000");
            await _userManager!.CreateAsync(adminUser, "000000");
            await _userManager.CreateAsync(driver, "000000");
            await _userManager.CreateAsync(customer, "000000");
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.CookingStaffRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.DeliveryDriverRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.CustomerRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.AdminRoleName });
            await _userManager.AddToRoleAsync(cook, RoleConstants.CookingStaffRoleName);
            await _userManager.AddToRoleAsync(driver, RoleConstants.DeliveryDriverRoleName);
            await _userManager.AddToRoleAsync(customer, RoleConstants.CustomerRoleName);
            await _userManager.AddToRoleAsync(adminUser, RoleConstants.AdminRoleName);
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            var order = await _orderService!.GetByIdAsync(orderId);
            await _orderService.UpdateOrderStatus(order.Id, cook.Id);
            await _orderService.UpdateOrderStatus(order.Id, cook.Id);
            await _orderService.UpdateOrderStatus(order.Id, driver.Id);
            await _orderService.UpdateOrderStatus(order.Id, driver.Id);
            var count = await _context.OrdersActionChronology.CountAsync(c => c.OrderId == orderId);
            Assert.That(count,Is.EqualTo(4));
        }

        [Test]
        public async Task UserIsInAllRoles()
        {
            var user = new ApplicationUser()
            {
                UserName = "user",
                Email = "user@test.bg",
                PhoneNumber = "user"
            };
            await _userManager!.CreateAsync(user, "000000");
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.CookingStaffRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.DeliveryDriverRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.CustomerRoleName });
            await _roleManager!.CreateAsync(new() { Name = RoleConstants.AdminRoleName });
            await _userManager.AddToRoleAsync(user, RoleConstants.CookingStaffRoleName);
            await _userManager.AddToRoleAsync(user, RoleConstants.DeliveryDriverRoleName);
            await _userManager.AddToRoleAsync(user, RoleConstants.CustomerRoleName);
            await _userManager.AddToRoleAsync(user, RoleConstants.AdminRoleName);
            await _addressService!.AddAddress(new AddressViewModel()
            {
                City = "Sofia",
                Street = "Test 123"
            }, UserConstants.AdminId);
            var address = await _context!.Addresses.FirstAsync();
            var product = await _context!.Products.FirstAsync();
            await _cartService!.AddCartProduct(product.Id, UserConstants.AdminId);
            var model = new OrderViewModel
            {
                Cart = new CartViewModel
                {
                    ProductAll = new List<ProductViewModel>()
                    {
                        new()
                        {
                            Id = product.Id,
                            QtyWanted = product.Quantity
                        }
                    },
                    CartOwner = UserConstants.AdminId
                },
                SelectedAddressId = address.Id,
                Addresses = new List<AddressViewModel>()
                {
                    new ()
                    {
                        AddressId = address.Id,
                        Street = address.Street,
                        City = address.City,
                        IsDeleted = address.IsDeleted
                    }
                },
                PaymentTypeValue = PaymentType.Cash.ToString()
            };
            var orderId = await _orderService!.PlaceOrder(model, UserConstants.AdminId);
            var order = await _orderService!.GetByIdAsync(orderId);
            Assert.That(order.Status.ToString(),Is.EqualTo(OrderStatus.Processing.ToString()));
            await _orderService.UpdateOrderStatus(order.Id, user.Id);
            Assert.That(order.Status.ToString(), Is.EqualTo(OrderStatus.Preparing.ToString()));
            await _orderService.UpdateOrderStatus(order.Id, user.Id);
            Assert.That(order.Status.ToString(), Is.EqualTo(OrderStatus.ReadyForDelivery.ToString()));
            await _orderService.UpdateOrderStatus(order.Id, user.Id);
            Assert.That(order.Status.ToString(), Is.EqualTo(OrderStatus.OnTheWay.ToString()));
            await _orderService.UpdateOrderStatus(order.Id, user.Id);
            Assert.That(order.Status.ToString(), Is.EqualTo(OrderStatus.Delivered.ToString()));
            var count = await _context.OrdersActionChronology.CountAsync(c => c.OrderId == orderId);
            Assert.That(count,Is.EqualTo(4));
        }
    }
}
