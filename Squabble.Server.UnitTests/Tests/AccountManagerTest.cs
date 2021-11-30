using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Squabble.Data;
using Squabble.Managers;
using Squabble.Models;
using Squabble.Models.Entities;
using System;
using Xunit;

namespace Squabble.Server.UnitTests.Tests
{
    public class AccountManagerTest
    {
        private readonly AccountManager _sut;
        private User TestUser;

        public AccountManagerTest()
        {
            _sut = new AccountManager(Utilities.GetDbContext(), new NullLogger<AccountManager>());

            TestUser = new User()
            {
                UserName = "username",
                Email = "test@email.com",
                FirstName = "firstname",
                MiddleName = "middlename",
                Surname = "surname"
            };
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void GetById_ShouldReturnUserWithId(int id)
        {
            var user = _sut.GetById(id);
            Assert.Equal(id, user.AccountId);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(1001)]
        [InlineData(1002)]
        public void GetById_ShouldReturnNull(int id)
        {
            var user = _sut.GetById(id);
            Assert.Null(user);
        }

        [Theory]
        [InlineData("Dragonborn")]
        [InlineData("Hayzeus")]
        [InlineData("Handyman")]
        public void GetByUsername_ShouldReturnUserWithId(string username)
        {
            var user = _sut.GetByUsername(username);
            Assert.Equal(username, user.UserName);
        }

        [Theory]
        [InlineData("NoUser1")]
        [InlineData("NoUser2")]
        [InlineData("NoUser3")]
        public void GetByUsername_ShouldReturnNull(string username)
        {
            var user = _sut.GetByUsername(username);
            Assert.Null(user);
        }

        [Fact]
        public void Add_ShouldReturnUserId()
        {
            var id = _sut.Add(TestUser).Result;

            Assert.True(id > 0);

            _sut.Delete((int)id);
        }

        [Fact]
        public void Delete_ShouldDeleteUserFromDatabase()
        {
            var id = _sut.Add(TestUser).Result;

            _sut.Delete((int)id);

            var user = _sut.GetById((int)id);

            Assert.Null(user);
        }

        //[Fact]
        //public void Update_ShouldUpdateUserWithNewUsername()
        //{
        //    var id = _sut.Add(TestUser).Result;
        //    var newUser = new User()
        //    {
        //        UserName = "newUsername",
        //        Email = "test@email.com",
        //        FirstName = "firstname",
        //        MiddleName = "middlename",
        //        Surname = "surname"
        //    };

        //    _sut.Update((int)id, newUser);

        //    var updatedUser = _sut.GetByUsername(newUser.UserName);

        //    Assert.Equal(newUser.UserName, updatedUser.UserName);

        //    _sut.Delete((int)id);
        //    _sut.Delete(updatedUser.AccountId);
        //}


    }
}
