using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using userAPI.DataManagement.Interfaces;
using userAPI.Models;

namespace userAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public List<User> Get()
        {
            return _userRepository.GetUsers();
        }


        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }


        [HttpPost]
        public User Post(User user)
        {
            return _userRepository.AddUser(user);
        }


        [HttpPut]
        public User Put(User user)
        {
            return _userRepository.UpdateUser(user);
        }



        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userRepository.DeleteUser(id);
        }

    }
}
