using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Interfaces.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<DTOs.User.UserDTO>> GetAllUsersAsync(Guid requesterId, UserRole requestingRole);
        public Task <DTOs.User.UserDTO?> GetUserByIdAsync(Guid id, Guid requesterID, UserRole requestingRole);
        public Task<DTOs.User.UserDTO> CreateUserAsync(DTOs.User.UserDTO user, Guid requesterId, UserRole requestingRole);
        public Task<DTOs.User.UserDTO?> UpdateUserAsync(Guid id, DTOs.User.UserDTO user, Guid requesterId, UserRole requestingRole);
        public Task<DTOs.User.UserDTO?> DeleteUserAsync(Guid id, Guid requesterId, UserRole requestingRole);
    }
}
