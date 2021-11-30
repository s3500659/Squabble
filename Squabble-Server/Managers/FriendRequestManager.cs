using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Squabble.Data;
using Squabble.Interfaces;
using Squabble.Models;
using Squabble.Models.ResponseModels;

namespace Squabble.Managers
{
    public class FriendRequestManager : IDataRepo<FriendRequest, int>
    {
        private readonly SquabbleContext _context;
        private readonly ILogger<FriendRequestManager> _logger;

        public FriendRequestManager(SquabbleContext context, ILogger<FriendRequestManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        // add a friend request, error if db can't write
        public async Task Add(int userId, int friendId)
        {
            try
            {
                await _context.FriendRequests.AddAsync(
                    new FriendRequest
                    {
                        SenderID = userId,
                        ReceiverID = friendId
                    }
                );
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError("Database could not be saved.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }
        }

        // get request by id, error if can't be found
        public async Task<FriendRequest> Get(int id)
        {
            var friend = await _context.FriendRequests.Where(x => x.FriendRequestID == id).FirstOrDefaultAsync();
            if (friend != null) return friend;
            _logger.LogInformation($"{id} was an invalid user");
            return null;
        }

        //return all the sent requests for a user
        public Task<List<FriendRequest>> GetFriendRequests(int id)
        {
            var friends = _context.FriendRequests.Where(x => x.SenderID == id).ToListAsync();
            return friends;
        }

        // accept a friend request
        public async Task AcceptFriendRequest(int friendRequestId, bool accepted)
        {
            try
            {
                var friendRequest = await _context.FriendRequests
                    .Where(x => x.FriendRequestID == friendRequestId)
                    .FirstOrDefaultAsync();

                if (friendRequest != null)
                {
                    friendRequest.Accepted = accepted;

                    if (accepted)
                    {
                        await _context.Friendships.AddRangeAsync(
                            new Friendship
                            {
                                FriendID = friendRequest.ReceiverID,
                                UserID = friendRequest.SenderID
                            },
                            new Friendship
                            {
                                FriendID = friendRequest.SenderID,
                                UserID = friendRequest.ReceiverID
                            }
                        );
                    }
                }

                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                _logger.LogError($"{friendRequestId} could not be written to the database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }
        }

        // get pending requests
        public Task<List<PendingFriendRequestsResponse>> GetPendingFriendRequests(int id)
        {
            return _context.FriendRequests
                .Where(x => (x.SenderID == id || x.ReceiverID == id) && x.Accepted == null)
                .Select(x =>
                    new PendingFriendRequestsResponse
                    {
                        FriendRequestId = x.FriendRequestID,
                        SenderAccountId = x.Sender.AccountId,
                        SenderUsername = x.Sender.UserName,
                        SenderCommunicationUserId = x.Sender.CommunicationUserId,
                        ReceiverAccountId = x.Receiver.AccountId,
                        ReceiverUsername = x.Receiver.UserName,
                        ReceiverCommunicationUserId = x.Receiver.CommunicationUserId
                    })
                .ToListAsync();
        }

        // delete a friend request
        public int? Delete(int id)
        {
            try
            {
                _context.FriendRequests.Remove(_context.FriendRequests.FirstOrDefault(x => x.FriendRequestID == id));

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogError($"Request {id} could not be deleted from the database.");
                _logger.LogError(e.Message);
                _logger.LogError(e.StackTrace);
            }

            return id;
        }

        public FriendRequest GetById(int id)
        {
            var friend = _context.FriendRequests.FirstOrDefault(x => x.FriendRequestID == id);
            if (friend != null) return friend;
            _logger.LogInformation($"{id} was an invalid user");
            return null;
        }

        // helper method to check if the request already exists
        public bool CheckDoubleRequest(int user, int friend)
        {
            return _context.FriendRequests.Any(x => x.ReceiverID == friend && x.SenderID == user) ||
                   _context.FriendRequests.Any(x => x.ReceiverID == user && x.SenderID == friend);
        }

        // helper method to check if the users are already friends
        public bool CheckIfFriends(int user, int friend)
        {
            return _context.Friendships.Any(x => x.UserID == user && x.FriendID == friend) ||
                   _context.Friendships.Any(x => x.UserID == friend && x.FriendID == user);
        }
    }
}
