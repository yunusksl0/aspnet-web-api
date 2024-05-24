using userAPI.Data;
using userAPI.DataManagement.Interfaces;
using userAPI.Models;

namespace userAPI.DataManagement.Repository
{
    public class UserRepository : IUserRepository // "ctrl + ." press and apply interface
    {
        Context _database = new Context();

        public User AddUser(User user)
        {
            _database.users.Add(user);
            _database.SaveChanges();
            return user;
        }

        public void DeleteUser(int id)
        {
            var userData = _database.users.FirstOrDefault(u => u.user_id == id);
            _database.users.Remove(userData);
            _database.SaveChanges();
        }

        public User GetById(int id)
        {
            var userData = _database.users.FirstOrDefault(u => u.user_id == id);
            return userData;
        }

        public List<User> GetUsers()
        {
            return _database.users.ToList();
        }

        public User UpdateUser(User user)
        {
            _database.users.Update(user);
            _database.SaveChanges();
            return user;
        }
    }
}
