using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Services
{
    public interface IUserService
    {
        // Create
        bool AddUser(UserDTO userDTO);

        // Read
        List<User> GetUsers();

        // Update
        bool UpdateUsername(string currentUserName, string newUsername);

        // Delete
        bool DeleteUser(string userName);
    }
}
