using BusarovsQuickBite.Core.Contracts;
using BusarovsQuickBite.Core.Services;
using BusarovsQuickBite.Infrastructure.Data;
using BusarovsQuickBite.Infrastructure.Data.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;
using ApplicationException = BusarovsQuickBite.Core.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class ImgServiceTests
    {
        private IImgService? _imgService;
        private Mock<IWebHostEnvironment>? _hostingEnvironmentMock;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private Mock<IFormFile>? _formFile;
        private string? _rootFullPath;
        private string? _imgFolderPath;
        [SetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<EmailServiceTests>()
                .Build();
            _rootFullPath = config["RootFullPath"];
            _dbOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("QuickBite" + Guid.NewGuid())
                .Options;
            _context = new ApplicationDbContext(_dbOptions);
            _context.Database.EnsureCreated();
            _hostingEnvironmentMock = new Mock<IWebHostEnvironment>();
            _hostingEnvironmentMock.Setup(h => h.WebRootPath).Returns(_rootFullPath);
            _hostingEnvironmentMock.Setup(h => h.ContentRootPath).Returns(_rootFullPath);
            _imgFolderPath = _rootFullPath + "Images";
            _formFile = new Mock<IFormFile>();
            _formFile.Setup(f => f.Length).Returns(1024);
            _formFile.Setup(f => f.FileName).Returns("test.jpg");
            _imgService = new ImgService(_hostingEnvironmentMock.Object, new Repository(_context));
        }
        [SetUp]
        public void SetUp()
        {
            _context!.Database.EnsureCreated();
        }
        [TearDown]
        public void TearDown()
        {
            File.Delete($"{_imgFolderPath}/test.jpg");
        }
        [Test]
        public async Task AddShouldWork()
        {
            int expectedId = _context!.Img.Count() + 1;
            var result = await _imgService!.AddImg(_formFile!.Object);
            Assert.That(result,Is.EqualTo(expectedId));
        }
        [Test]
        public void ExtenstionIsInvalidShouldThrow()
        {
            _formFile!.Setup(f => f.FileName).Returns("test.html");
            Assert.ThrowsAsync<ApplicationException>(async () => await _imgService!.AddImg(_formFile!.Object));
            File.Delete($"{_imgFolderPath}/test.html");
        }
        [Test]
        public void LengthIsInvalidShouldThrow()
        {
            _formFile!.Setup(f => f.Length).Returns(2 * 1024 * 1024 + 1);
            Assert.ThrowsAsync<ApplicationException>(async () => await _imgService!.AddImg(_formFile!.Object));
        }
        [Test]
        public void NameIsTooLongShouldThrow()
        {
            string name = "name1";
            string result = "";
            for (int i = 0; i < 300 / name.Length; i++)
            {
                result += name;
            }
            result += ".jpg";
            _formFile!.Setup(f => f.FileName).Returns(result);
            Assert.ThrowsAsync<ApplicationException>(async Task () => await _imgService!.AddImg(_formFile!.Object));
        }
        [Test]
        public async Task FileIsInFolderButNotInDb()
        {
            await _imgService!.AddImg(_formFile!.Object);
            await _context!.Database.EnsureDeletedAsync();
            await _context.Database.EnsureCreatedAsync();
            Assert.ThrowsAsync<ApplicationException>(async Task () => await _imgService!.AddImg(_formFile!.Object));
        }
        [Test]
        public async Task ExistingFileShouldReturnCorrectId()
        {
            int expectedId = _context!.Img.Count() + 1;
            var id = await _imgService!.AddImg(_formFile!.Object);
            var addAgain = await _imgService!.AddImg(_formFile!.Object);
            Assert.That(expectedId,Is.EqualTo(addAgain));
        }
        [Test]
        public async Task FileShouldExistsOnFileSystem()
        {
           await _imgService!.AddImg(_formFile!.Object);
           var fileShouldExist = File.Exists($"{_imgFolderPath}/test.jpg");
           Assert.IsTrue(fileShouldExist);
        }
        [Test]
        public async Task DeleteUnusedImageForProduct()
        {
            int expectedCount = _context!.Img.Count() + 1;
            await _imgService!.AddImg(_formFile!.Object);
            Assert.That(_context!.Img.Count(),Is.EqualTo(expectedCount));
            await _imgService.DeleteUnusedImages();
            Assert.That(_context!.Img.Count(), Is.EqualTo(expectedCount - 1));
            var fileShouldBeDeleted = File.Exists($"{_imgFolderPath}/test.jpg");
            Assert.IsFalse(fileShouldBeDeleted);
        }
    }
}
