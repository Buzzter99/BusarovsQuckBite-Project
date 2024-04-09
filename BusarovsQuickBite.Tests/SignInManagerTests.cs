using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Services;
using BusarovsQuickBite.Tests.FakeManager;
namespace BusarovsQuickBite.Tests
{
    [TestFixture]
    public class SignInManagerTests
    {
        private readonly ApplicationSignInManager<ApplicationUser> _signInManager = FakeManager<ApplicationUser>.CreateMockSignInManager();
        private readonly ApplicationUser _user = new();

        [Test]
        public async Task TestActiveUser()
        {
            _user.IsActive = true;
            var canSignIn = await _signInManager.CanSignInAsync(_user);
            Assert.IsTrue(canSignIn);
        }
        [Test]
        public async Task TestInActiveUser()
        {
            _user.IsActive = false;
            var canSignIn = await _signInManager.CanSignInAsync(_user);
            Assert.IsFalse(canSignIn);
        }
    }
}
