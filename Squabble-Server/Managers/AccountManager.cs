using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Squabble.Data;
using Squabble.Interfaces;
using Squabble.Models.Entities;

namespace Squabble.Managers
{
    public class AccountManager : IDataRepo<User, int>
    {

        private readonly SquabbleContext _context;
        private readonly ILogger<AccountManager> _logger;

        public AccountManager(SquabbleContext context, ILogger<AccountManager> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Returns an Account object with the matching ID if it exists.
        /// </summary>
        public User GetById(int id)
        {
            var acc = _context.Accounts.FirstOrDefault(x => x.AccountId == id);
            if (acc != null) return acc;
            _logger.LogWarning($"{id} - Account does not exist."); return null;
        }

        /// <summary>
        /// Returns an Account object with the matching username if it exists.
        /// </summary>
        public User GetByUsername(string username)
        {
            var accs = _context.Accounts.ToList();
            var acc = accs.FirstOrDefault(x => string.Equals(x.UserName, username, StringComparison.OrdinalIgnoreCase));
            if (acc != null) return acc;
            _logger.LogWarning($"{username} - Account does not exist."); return null;
        }


        /// <summary>
        /// Returns an Account object with the matching username if it exists.
        /// </summary>
        public User GetByEmail(string email)
        {
            var acc = _context.Accounts.FirstOrDefault(x => string.Equals(x.Email, email));
            if (acc != null) return acc;
            _logger.LogWarning($"{email} - Account does not exist."); return null;
        }

        /// <summary>
        /// Returns an Account object with the matching username if it exists.
        /// </summary>
        public User GetByCommunicationUserId(string id)
        {
            var acc = _context.Accounts.FirstOrDefault(x => string.Equals(x.CommunicationUserId, id));
            if (acc != null) return acc;
            _logger.LogWarning($"{id} - Account does not exist."); return null;
        }

        //Returns account id if account created. Returns null if it cannot be created
        public async Task<int?> Add(User account)
        {
            if (account == null) { _logger.LogWarning("Account cannot be null."); return null; }
            if (_context.Accounts.Where(x => x.UserName == account.UserName) == null
                    || _context.Accounts.Where(x => x.UserName == account.Email) == null)
            {
                _logger.LogInformation($"{account.UserName}, {account.Email} - Account creation failed due to insufficient information.");
                return null;
            }
            try
            {
                await _context.Accounts.AddAsync(account);
                await _context.SaveChangesAsync();
            } catch (Exception e)
            {
                _logger.LogWarning("Error occurred with adding to database.");
                _logger.LogWarning(e.Message);
                _logger.LogWarning(e.StackTrace);
                return null;
            }

            return _context.Accounts.Where(x => x.UserName == account.UserName).FirstOrDefault().AccountId;
        }

        //throw request here, update and save then return the acc id
        public void Update(User account)
        {
            if (account == null)
            {
                _logger.LogWarning("Account cannot be null.");
                return;
            }

            try
            {
                _context.Update(account);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogWarning("Error occurred with updating account in database.");
                _logger.LogWarning(e.Message);
                _logger.LogWarning(e.StackTrace);
            }
        }

        //remove account. throw error and log stack trace and error message if fail
        public int Delete(int id)
        {
            try
            {
                _context.Accounts.Remove(_context.Accounts.Find(id));
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogWarning("Error occurred with deleting account in database.");
                _logger.LogWarning(e.Message);
                _logger.LogWarning(e.StackTrace);
                return -1;
            }

            return id;
        }

    }
}
