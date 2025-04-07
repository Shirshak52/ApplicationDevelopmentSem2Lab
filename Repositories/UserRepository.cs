using System.Transactions;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InsertUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public bool UpdateUsername(string currentUsername, string newUsername)
        {
            var user = _context.Users.Where(u => u.Username == currentUsername).FirstOrDefault();
            if (user == null) { return false; }
            else
            {   
                user.Username = newUsername;
                _context.SaveChanges();
                return true;
            }
        }

        public bool DeleteUser(string userName)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == userName);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
