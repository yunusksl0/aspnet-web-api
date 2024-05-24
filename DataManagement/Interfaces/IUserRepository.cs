using userAPI.Models;

namespace userAPI.DataManagement.Interfaces
{
    public interface IUserRepository
    {

        public List<User> GetUsers();

        User GetById(int id);

        User AddUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
