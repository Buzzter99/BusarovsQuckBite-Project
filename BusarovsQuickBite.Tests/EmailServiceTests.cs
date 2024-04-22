using BusarovsQuickBite.Core.Services;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;

namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class EmailServiceTests
    {
        private readonly IEmailSender _emailService;

        public EmailServiceTests()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<EmailServiceTests>()
                .Build();
            _emailService = new EmailService(config);
        }
        [Test]
        public void SendEmailTest()
        {
            Assert.DoesNotThrowAsync(async () => await _emailService.SendEmailAsync("ryuuzzakii@abv.bg", "subject", "<h1>test</h1>"));
        }

    }
}
