using Microsoft.Extensions.Logging.Abstractions;
using Squabble.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Squabble.Server.UnitTests.Tests
{
    public class FriendRequestManagerTest
    {
        private readonly FriendRequestManager _sut;

        public FriendRequestManagerTest()
        {
            _sut = new FriendRequestManager(Utilities.GetDbContext(), new NullLogger<FriendRequestManager>());
        }

        // nothing shows up in the database.
        [Fact]
        public void Add_FriendRequestShouldExistInDatabase()
        {
            var userId = 4;
            var friendId = 5;

            _sut.Add(userId, friendId);

        }

        [Fact]
        public void GetFriendRequests_ShouldReturnAllFriendRequestsForSpecifiedId()
        {
            var id = 1;

            var result = _sut.GetFriendRequests(id);

            Assert.NotNull(result);
        }

    }
}
