using Microsoft.Extensions.Configuration;
using Squabble.Managers;
using Xunit;

namespace Squabble.Server.UnitTests.Tests
{
    public class CommunicationTokenManagerTests
    {
        private readonly CommunicationTokenManager _sut;

        public CommunicationTokenManagerTests()
        {
            _sut = new CommunicationTokenManager(Utilities.GetIConfiguration());
        }

        [Fact]
        public void CreateUser_ShouldReturnUserIdString()
        {
            string id = _sut.CreateUserAsync().Result.Id;
            
            Assert.True(id.Length > 0, "Id string is empty");
        }

        [Fact]
        public void CreateToken_ShouldReturnTokenIdString()
        {
            var id = _sut.CreateUserAsync().Result;
            var token = _sut.CreateTokenAsync(id).Result.Token;
            Assert.True(token.Length > 0, "Token string is empty");
        }

        [Fact]
        public void CreateUserAndToken_ShouldReturnUserAndToken()
        {
            var userAndToken = _sut.CreateUserAndTokenAsync();
            var userId = userAndToken.Result.User.Id;
            var token = userAndToken.Result.AccessToken.Token;

            Assert.True(userId.Length > 0, "User Id string is empty");
            Assert.True(token.Length > 0, "Token string is empty");
        }

        [Fact]
        public void RefreshToken_ShouldReturnRefreshedToken()
        {
            var userAndToken = _sut.CreateUserAndTokenAsync();
            var userId = userAndToken.Result.User.Id;
            var token = userAndToken.Result.AccessToken;

            var refreshedToken = _sut.RefreshToken(userId);

            Assert.True(token.ExpiresOn < refreshedToken.Result.ExpiresOn);

        }
    }
}
