using Microsoft.AspNetCore.Mvc;
using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Entities;
using web_api_labclass_4_mar_25.Repositories;

namespace web_api_labclass_4_mar_25.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AddUser(UserDTO userDTO)
        {
            var newUser = new User
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                Password = userDTO.Password,
                Username = userDTO.Username,
            };

            _userRepository.InsertUser(newUser);
            return true;
        }

        public List<User> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public bool UpdateUsername(string currentUserName, string newUsername)
        {
            var isUsernameUpdated = _userRepository.UpdateUsername(currentUserName, newUsername);

            return isUsernameUpdated;
        }

        public bool DeleteUser(string userName)
        {
            var isUserDeleted = _userRepository.DeleteUser(userName);

            return isUserDeleted;
        }
    }
}
