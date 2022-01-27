using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiWebSys.Contracts;
using WebApiWebSys.Entities;

namespace WebApiWebSys.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserContext _userContext;
        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }
        public async Task<User> CreateUser(User user)
        {
            await _userContext.AddAsync(user);
            return user;
        }

        public async Task DeleteUser(int userId)
        {
            var userToDelete = await _userContext.Users.FirstOrDefaultAsync(x => x.Id == userId);
            _userContext.Remove(userToDelete);
        }

        public async Task<IEnumerable<User>> ListUsers()
        {
            var users = await _userContext.Users.AsNoTracking().ToListAsync();
            return users;
        }
    }
}
