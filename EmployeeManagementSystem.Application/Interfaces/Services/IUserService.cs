using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Interfaces.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<DTOs.User.UserDTO>> GetAllUsersAsync();
        public Task <DTOs.User.UserDTO?> GetUserByIdAsync(Guid id);
        public Task<DTOs.User.UserDTO> CreateUserAsync(DTOs.User.UserDTO user);
        public Task<DTOs.User.UserDTO?> UpdateUserAsync(Guid id, DTOs.User.UserDTO user);
        public Task<DTOs.User.UserDTO?> DeleteUserAsync(Guid id);
    }
}
