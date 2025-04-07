using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Repositories
{
    public interface IUserRepository
    {
        // Create
        void InsertUser(User newUser);

        // Read
        List<User> GetUsers();

        // Update
        bool UpdateUsername(string currentUsername, string newUsername);

        // Delete
        bool DeleteUser(string userName);
    }
}
