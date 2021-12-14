using Squabble.Models.Entities;
using System.Threading.Tasks;

namespace Squabble.Managers
{
    public interface IAccountManager
    {
        Task<int?> Add(User account);
        int Delete(int id);
        User GetByCommunicationUserId(string id);
        User GetByEmail(string email);
        User GetById(int id);
        User GetByUsername(string username);
        void Update(User account);
    }
}