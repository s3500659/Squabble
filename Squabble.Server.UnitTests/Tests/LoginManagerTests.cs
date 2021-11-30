using Microsoft.Extensions.Logging.Abstractions;
using Squabble.Managers;
using Xunit;

namespace Squabble.Server.UnitTests.Tests
{
    public class LoginManagerTests
    {
        private readonly LoginManager _sut;
        private readonly AccountManager _accountManager;

        public LoginManagerTests()
        {
            _sut = new LoginManager(Utilities.GetDbContext(), new NullLogger<LoginManager>());
            _accountManager = new AccountManager(Utilities.GetDbContext(), new NullLogger<AccountManager>());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void GetById_ShouldReturnLoginWithSpecifiedId(int id)
        {
            var login = _sut.GetById(id);

            Assert.Equal(id, login.AccountId);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        public void GetById_ShouldNotReturnLoginWithSpecifiedId(int id)
        {
            var login = _sut.GetById(id);

            Assert.Null(login);
        }

        [Theory]
        [InlineData("Dragonborn")]
        [InlineData("Hayzeus")]
        [InlineData("Handyman")]
        [InlineData("Spongebob")]
        [InlineData("Squidward")]
        [InlineData("test1@test.com")]
        [InlineData("test2@test.com")]
        [InlineData("test3@test.com")]
        [InlineData("bikinibottom1@test.com")]
        [InlineData("bikinibottom2@test.com")]
        public void GetByEmailOrUsername_ShouldReturnValidLogin(string userNameOrEmail)
        {
            var login = _sut.GetByEmailOrUsername(userNameOrEmail);
            Assert.NotNull(login);
        }

        [Theory]
        [InlineData("Dragonborn9")]
        [InlineData("Hayzeus9")]
        [InlineData("Handyman9")]
        [InlineData("Spongebob9")]
        [InlineData("Squidward9")]
        [InlineData("test1@test.co9m")]
        [InlineData("test2@test.co9m")]
        [InlineData("test3@test.c9om")]
        [InlineData("bikinibottom19@test.com")]
        [InlineData("bikinibottom2@9test.com")]
        public void GetByEmailOrUsername_ShouldNotReturnValidLogin(string userNameOrEmail)
        {
            var login = _sut.GetByEmailOrUsername(userNameOrEmail);
            Assert.Null(login);
        }
    }
}
