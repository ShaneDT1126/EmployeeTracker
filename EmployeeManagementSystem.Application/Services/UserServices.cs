using EmployeeManagementSystem.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Services
{
    public class UserServices : Interfaces.Services.IUserService
    {
        public Task<UserDTO> CreateUserAsync(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO?> DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO?> GetUserByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO?> UpdateUserAsync(Guid id, UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
