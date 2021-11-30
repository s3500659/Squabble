using Microsoft.Extensions.Logging.Abstractions;
using Squabble.Managers;
using Squabble.Models;
using Xunit;

namespace Squabble.Server.UnitTests.Tests
{
    public class ChannelManagerTests
    {
        private readonly ChannelManager _sut;

        public ChannelManagerTests()
        {
            _sut = new ChannelManager(Utilities.GetDbContext(), new NullLogger<ChannelManager>());
        }

        [Fact]
        public void Add_ShouldAddNewChannelToDB()
        {
            var newChannel = new Channel
            {
                ChannelName = "My Test Channel",
                ServerID = 1
            };

            var channelId = _sut.Add(newChannel).Result;
            Assert.True(channelId > 0);

            _sut.Delete(channelId);
        }

        [Fact]
        public void Get_ShouldReturnChannelWithGivenId()
        {
            var id = 1;

            var channel = _sut.Get(id).Result;

            Assert.Equal(id, channel.ChannelId);
        }

        [Fact]
        public void Get_ShouldNotReturnChannelWithGivenId()
        {
            var id = -1;

            var channel = _sut.Get(id).Result;

            Assert.Null(channel);
        }

        [Fact]
        public void Delete_ShouldDeleteChannelWithGivenId()
        {
            var newChannel = new Channel
            {
                ChannelName = "My Test Channel",
                ServerID = 1
            };

            var channelId = _sut.Add(newChannel).Result;

            var deletedChannelId = _sut.Delete(channelId);

            Assert.Equal(channelId, deletedChannelId);
        }

        [Fact]
        public void Delete_ShouldNotDeleteChannelWithGivenId()
        {
            var id = -1;

            var deletedChannelId = _sut.Delete(id);

            Assert.Equal(id, deletedChannelId);
        }
    }
}
