using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;
using Moq;
using System.Text;
using BusarovsQuckBite.Contracts;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class DataProtectionServiceTests
    {
        private IDataProtectionService? _dataProtectionService;

        [SetUp]
        public void SetUp()
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
        }
        [Test]
        public void TestShouldReturnSameValue()
        {
            string password = "MySuperSectedPassword123";
            string encrypted = _dataProtectionService!.Encrypt(password);
            Assert.That(encrypted, Is.Not.EqualTo(password));
            string decrypted = _dataProtectionService.Decrypt(encrypted);
            Assert.That(decrypted,Is.EqualTo(password));
        }
    }
    
}
