using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiWebSys.Contracts;
using WebApiWebSys.Entities;

namespace WebApiWebSys.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsersList()
        {
            return await _userRepository.ListUsers();
        }

        [HttpPost]
        public async Task<User> PostUser(User userToCreate)
        {
            return await _userRepository.CreateUser(userToCreate);
        }

        [HttpDelete]
        public async Task DeleteUser(int userId)
        {
            await _userRepository.DeleteUser(userId);
        }

    }
}
