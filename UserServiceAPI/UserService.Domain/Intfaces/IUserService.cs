using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserService.Domain.Intfaces
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int id);
        Task<List<User>> GetAllUsersAsync();
        Task<int> InsertUserAsync(User _user);
        Task UpdateUserAsync(User _user);
        Task DeleteUserAsync(int id);
    }
}
