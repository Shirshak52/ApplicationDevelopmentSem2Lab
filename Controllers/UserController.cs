using Microsoft.AspNetCore.Mvc;
using web_api_labclass_4_mar_25.DTOs;
using web_api_labclass_4_mar_25.Services;
using web_api_labclass_4_mar_25.Entities;

namespace web_api_labclass_4_mar_25.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add-user")]
        public IActionResult AddUser(UserDTO userInfo)
        {
            var isUserCreated = _userService.AddUser(userInfo);

            if (isUserCreated)
            {
                return Ok("User created");
            }
            return BadRequest("Unable to create user");
        }

        [HttpGet("get-users")]
        public List<User> GetUsers()
        {
            var userList = _userService.GetUsers();
            return userList;
        }

        [HttpPut("update-username")]
        public IActionResult UpdateUsername(string currentUserName, string newUsername)
        {
            var isUsernameUpdated = _userService.UpdateUsername(currentUserName, newUsername);
            if (isUsernameUpdated)
            {
                return Ok($"User {currentUserName} updated to {newUsername} successfully");
            }
            else
            {
                return BadRequest("Unable to update username");
            }
        }

        [HttpDelete("delete-user")]
        public IActionResult DeleteUser(string userName)
        {
            var isUserDeleted = _userService.DeleteUser(userName);
            if (isUserDeleted)
            {
                return Ok($"User {userName} deleted successfully");
            }
            else
            {
                return BadRequest("Unable to delete user");
            }
        }
    }
}
