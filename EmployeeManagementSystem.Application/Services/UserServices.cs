using EmployeeManagementSystem.Application.DTOs.User;
using EmployeeManagementSystem.Application.Mappers.User;
using EmployeeManagementSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Services
{
    public class UserServices : Interfaces.Services.IUserService
    {
        private readonly Interfaces.Repositories.IUserRepository _userRepository;
        public UserServices(Interfaces.Repositories.IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> CreateUserAsync(UserDTO user, Guid requesterId, UserRole requestingRole)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO?> DeleteUserAsync(Guid id, Guid requesterId, UserRole requestingRole)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync(Guid requesterId, UserRole requestingRole)
        {
            var users = await _userRepository.GetAllUsersAsync();
            if (!users.Any())
            {
                return new List<UserDTO>();
            }

            return requestingRole switch
            {
                UserRole.Admin => users.Select(u => u.ToAdminUserDTO()),
                UserRole.Manager => users.Where(u => u.Id == requesterId).Select(u => u.ToManagerUserDTO()),
                UserRole.Employee => throw new UnauthorizedAccessException("Employees cannot view all users."),
                _ => throw new NotSupportedException("Unsupported user role.")
            };
        }

        public async Task<UserDTO?> GetUserByIdAsync(Guid id, Guid requesterID, UserRole requestingRole)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                return null;
            }

            return requestingRole switch
            {
                UserRole.Admin => user.ToAdminUserDTO(),
                UserRole.Manager when user.Id == requesterID => user.ToManagerUserDTO(),
                UserRole.Employee when user.Id == requesterID => user.ToEmployeeUserDTO(),
                _ => throw new UnauthorizedAccessException("You do not have permission to view this user.")
            };
        }

        public async Task<UserDTO?> UpdateUserAsync(Guid id, UserDTO user, Guid requesterId, UserRole requestingRole)
        {
            throw new NotImplementedException();
        }
    }
}
