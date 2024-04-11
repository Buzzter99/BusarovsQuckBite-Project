using BusarovsQuckBite.Data;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using ApplicationException = BusarovsQuckBite.Exceptions.ApplicationException;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class ImgServiceTests
    {
        private ImgService? _imgService;
        private Mock<IWebHostEnvironment>? _hostingEnvironmentMock;
        private DbContextOptions<ApplicationDbContext>? _dbOptions;
        private ApplicationDbContext? _context;
        private Mock<IFormFile>? _formFile;
        [SetUp]
        public void Setup()
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
        }
        [SetUp]
        public void SetUp()
        {
            _context!.Database.EnsureCreated();
        }
        [TearDown]
        public void TearDown()
        {
            File.Delete($@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.jpg");
        }
        [Test]
        public async Task AddShouldWork()
        {
            int expectedId = _context!.Img.Count() + 1;
            var result = await _imgService!.AddImg(_formFile!.Object);
            Assert.That(result,Is.EqualTo(expectedId));
        }
        [Test]
        public async Task ExtenstionIsInvalidShouldThrow()
        {
            _formFile!.Setup(f => f.FileName).Returns("test.html");
            Assert.ThrowsAsync<ApplicationException>(async () => await _imgService!.AddImg(_formFile!.Object));
            File.Delete($@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.html");
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
            for (int i = 0; i < 150 / name.Length; i++)
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
            int expectedId = 4;
            var id = await _imgService!.AddImg(_formFile!.Object);
            var addAgain = await _imgService!.AddImg(_formFile!.Object);
            Assert.That(expectedId,Is.EqualTo(addAgain));
        }
        [Test]
        public async Task FileShouldExistsOnFileSystem()
        {
           await _imgService!.AddImg(_formFile!.Object);
           var fileShouldExist = File.Exists(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.jpg");
           Assert.IsTrue(fileShouldExist);
        }
        [Test]
        public async Task DeleteUnusedImageForProduct()
        {
            int expectedCount = 4;
            await _imgService!.AddImg(_formFile!.Object);
            Assert.That(_context!.Img.Count(),Is.EqualTo(expectedCount));
            await _imgService.DeleteUnusedImages();
            Assert.That(_context!.Img.Count(), Is.EqualTo(expectedCount - 1));
            var fileShouldBeDeleted = File.Exists(@"C:\Users\GRIGS\source\repos\BusarovsQuckBite\BusarovsQuckBite\wwwroot\Images\test.jpg");
            Assert.IsFalse(fileShouldBeDeleted);
        }
        [Test]
        public async Task FilesShouldBeDeletedFromFileSystemWhenNotInDb()
        {
            await _imgService!.AddImg(_formFile!.Object);
            await _context!.Database.EnsureDeletedAsync();
            await _context.Database.EnsureCreatedAsync();
            string wwwRootPath = _hostingEnvironmentMock!.Object.WebRootPath + "\\Images";
            string[] filesBeforeDelete = Directory.GetFiles(wwwRootPath, "*.*", SearchOption.AllDirectories);
            int actual = filesBeforeDelete.Length;
            int expected = 4;
            Assert.That(actual,Is.EqualTo(expected));
            await _imgService.DeleteUnusedImages();
            string[] filesAfterDelete = Directory.GetFiles(wwwRootPath, "*.*", SearchOption.AllDirectories);
            Assert.That(filesAfterDelete.Length,Is.EqualTo(expected - 1));
        }
    }
}
