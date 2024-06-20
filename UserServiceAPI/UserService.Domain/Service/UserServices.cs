using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Domain.Intfaces;

namespace UserService.Domain.Service
{
    public class UserServices: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<int> InsertUserAsync(User _user)
        {
            await _userRepository.AddAsync(_user);
            return _user.Id; // Return the ID of the newly created user
        }

        public async Task UpdateUserAsync(User _user)
        {
            await _userRepository.UpdateAsync(_user);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}
