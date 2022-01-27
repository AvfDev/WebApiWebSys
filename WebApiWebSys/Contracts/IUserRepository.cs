using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiWebSys.Entities;

namespace WebApiWebSys.Contracts
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<IEnumerable<User>> ListUsers();
        Task DeleteUser(int userId);
    }
}
