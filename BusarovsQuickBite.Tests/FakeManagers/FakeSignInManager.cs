using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
namespace BusarovsQuickBite.Tests.FakeManagers
{
    public class FakeManager<T> where T : ApplicationUser
    {
        public static ApplicationSignInManager<T> CreateMockSignInManager()
        {
            var userManagerMock = new Mock<UserManager<T>>(
                Mock.Of<IUserStore<T>>(),
                null, null, null, null, null, null, null, null);

            var contextAccessorMock = new Mock<IHttpContextAccessor>();
            var claimsFactoryMock = new Mock<IUserClaimsPrincipalFactory<T>>();
            var optionsAccessorMock = new Mock<IOptions<IdentityOptions>>();
            var loggerMock = new Mock<ILogger<SignInManager<T>>>();
            var schemesMock = new Mock<IAuthenticationSchemeProvider>();
            var confirmationMock = new Mock<IUserConfirmation<T>>();
            var signInManager = new ApplicationSignInManager<T>(
                userManagerMock.Object,
                contextAccessorMock.Object,
                claimsFactoryMock.Object,
                optionsAccessorMock.Object,
                loggerMock.Object,
                schemesMock.Object,
                confirmationMock.Object);
            return signInManager;
        }
    }
}