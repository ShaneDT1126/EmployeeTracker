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

        public async Task<UserViewDTO> CreateUserAsync(UserCreateAndUpdateDTO user, Guid requesterId, UserRole requestingRole)
        {
            if (requestingRole != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only admins can create users.");
            }

            var userEntity = user.ToAdminUserCreateEntity();
            var newUser = await _userRepository.CreateUserAsync(userEntity);

            return newUser.ToAdminUserViewDTO();
        }

        public async Task<UserViewDTO?> DeleteUserAsync(Guid id, Guid requesterId, UserRole requestingRole)
        {
            if (requestingRole != UserRole.Admin)
            {
                throw new UnauthorizedAccessException("Only admins can delete users.");
            }

            var userToDelete = await _userRepository.GetUserByIdAsync(id);
            
            if (userToDelete == null)
            {
                return null; // User not found
            
            }

            await _userRepository.DeleteUserAsync(id);

            return userToDelete.ToAdminUserViewDTO();
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

        public async Task<UserViewDTO?> UpdateUserAsync(Guid id, UserCreateAndUpdateDTO user, Guid requesterId, UserRole requestingRole)
        {
            var existingUser = await _userRepository.GetUserByIdAsync(id);
            if (existingUser == null)
            {
                return null; // User not found
            }

            if (requestingRole == UserRole.Admin)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Role = user.Role;
                existingUser.ManagerId = user.ManagerId;
                existingUser.DepartmentId = user.DepartmentId;
            }else if (requestingRole == UserRole.Manager || requestingRole == UserRole.Employee)
            {
                if (existingUser.Id != requesterId && existingUser.ManagerId != requesterId)
                {
                    throw new UnauthorizedAccessException("You do not have permission to update this user.");
                }
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
            } else
            {
                throw new UnauthorizedAccessException("You do not have permission to update this user.");
            }

            await _userRepository.UpdateUserAsync(id, existingUser);

            return requestingRole switch
            {
                UserRole.Admin => existingUser.ToAdminUserViewDTO(),
                UserRole.Manager => existingUser.ToManagerUserViewDTO(),
                UserRole.Employee => existingUser.ToEmployeeUserViewDTO(),
                _ => throw new NotSupportedException("Unsupported user role.")
            };
        }
    }
}
