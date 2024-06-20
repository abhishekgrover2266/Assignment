using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Domain;
using UserService.Domain.Service;

namespace User_Service.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly UserServices _userService;
        private readonly ILogger<UserController> Log;

        public UserController(UserServices userService, ILogger<UserController> logger)
        {
            _userService = userService;
            Log = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var _user = await _userService.GetUserByIdAsync(id);
            if (_user == null)
            {
                Log.LogError("File Not Found // ");
                return NotFound();
            }
            return Ok(_user);
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var _user = await _userService.GetAllUsersAsync();

            return Ok(_user);
        }

        [HttpPost]
        public async Task<ActionResult<int>> InsertUser(User _user)
        {
            var _userID = await _userService.InsertUserAsync(_user);
            return Ok(_userID);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, User _user)
        {
            if (id != _user.Id)
            {
                return BadRequest("_user ID mismatch");
            }

            await _userService.UpdateUserAsync(_user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await _userService.DeleteUserAsync(id);
            return NoContent();
        }
    }
}
