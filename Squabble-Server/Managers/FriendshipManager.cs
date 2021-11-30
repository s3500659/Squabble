using Squabble.Data;
using Squabble.Interfaces;
using Squabble.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace Squabble.Managers
{
    public class FriendshipManager : IDataRepo<Friendship, int>
    {
        private readonly SquabbleContext _context;
        private readonly ILogger<FriendshipManager> _logger;

        public FriendshipManager(SquabbleContext context, ILogger<FriendshipManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        // add a friend
        public async Task<int?> Add(Friendship friendship)
        {
            try
            {
                await _context.Friendships.AddAsync(friendship);
                await _context.Friendships.AddAsync(new Friendship { UserID = friendship.FriendID, FriendID = friendship.UserID });
                await _context.SaveChangesAsync();
            } catch(Exception e)
            {
                _logger.LogError("Could not add friends to database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }
            return friendship.FriendID;
        }

        // get a friend relation
        public async Task<Friendship> Get(int userID, int friendID)
        {
            return await _context.Friendships.Where(x => x.FriendID == friendID && x.UserID == userID).FirstOrDefaultAsync();
        }

        // get all friends of a user
        public async Task<List<FriendInfo>> GetFriends(int id)
        {
            var friendInfos = new List<FriendInfo>();
            try
            {
                friendInfos.AddRange((await _context.Friendships.Where(x => x.UserID == id).ToListAsync()).Select(friendship => _context.Accounts.FirstOrDefault(x => x.AccountId == friendship.FriendID))
                .Select(ac => new FriendInfo
                {
                    AccountId = ac.AccountId,
                    ACSId = ac.CommunicationUserId,
                    FirstName = ac.FirstName,
                    MiddleName = ac.MiddleName,
                    Surname = ac.Surname,
                    UserName = ac.UserName
                }));
            } catch (Exception e)
            {
                _logger.LogError("Could not get friend info from the database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }

            return friendInfos;
        }

        //delete a friend
        public int? Delete(int userID, int friendID)
        {
            try
            {
                _context.Friendships.Remove(_context.Friendships.FirstOrDefault(x => x.FriendID == friendID && x.UserID == userID));
                _context.Friendships.Remove(_context.Friendships.FirstOrDefault(x => x.FriendID == userID && x.UserID == friendID));

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError("Could not remove friendships from the database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }


            return friendID;
        }

        // get a friend via id
        public Friendship GetById(int id)
        {
            return _context.Friendships.FirstOrDefault(x => x.UserID == id);
        }
    }
}
