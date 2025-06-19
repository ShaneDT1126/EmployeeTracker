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

        public async Task<UserCreateAndUpdateDTO> CreateUserAsync(UserCreateAndUpdateDTO user, Guid requesterId, UserRole requestingRole)
        {
            throw new NotImplementedException();
        }

        public async Task<UserViewDTO?> DeleteUserAsync(Guid id, Guid requesterId, UserRole requestingRole)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserViewDTO>> GetAllUsersAsync(Guid requesterId, UserRole requestingRole)
        {
            var users = await _userRepository.GetAllUsersAsync();
            if (!users.Any())
            {
                return new List<UserViewDTO>();
            }

            return requestingRole switch
            {
                UserRole.Admin => users.Select(u => u.ToAdminUserViewDTO()),
                UserRole.Manager => users.Where(u => u.ManagerId == requesterId).Select(u => u.ToManagerUserViewDTO()),
                UserRole.Employee => throw new UnauthorizedAccessException("Employees cannot view all users."),
                _ => throw new NotSupportedException("Unsupported user role.")
            };
        }

        public async Task<UserViewDTO?> GetUserByIdAsync(Guid id, Guid requesterID, UserRole requestingRole)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                return null;
            }

            return requestingRole switch
            {
                UserRole.Admin => user.ToAdminUserViewDTO(),
                UserRole.Manager when user.Id == requesterID => user.ToManagerUserViewDTO(),
                UserRole.Manager when user.ManagerId == requesterID => user.ToManagerUserViewDTO(),
                UserRole.Employee when user.Id == requesterID => user.ToEmployeeUserViewDTO(),
                _ => throw new UnauthorizedAccessException("You do not have permission to view this user.")
            };
        }

        public async Task<UserCreateAndUpdateDTO?> UpdateUserAsync(Guid id, UserCreateAndUpdateDTO user, Guid requesterId, UserRole requestingRole)
        {
            throw new NotImplementedException();
        }
    }
}
