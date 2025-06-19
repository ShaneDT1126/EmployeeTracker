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
        public Task<IEnumerable<DTOs.User.UserViewDTO>> GetAllUsersAsync(Guid requesterId, UserRole requestingRole);
        public Task <DTOs.User.UserViewDTO?> GetUserByIdAsync(Guid id, Guid requesterID, UserRole requestingRole);
        public Task<DTOs.User.UserCreateAndUpdateDTO> CreateUserAsync(DTOs.User.UserCreateAndUpdateDTO user, Guid requesterId, UserRole requestingRole);
        public Task<DTOs.User.UserCreateAndUpdateDTO?> UpdateUserAsync(Guid id, DTOs.User.UserCreateAndUpdateDTO user, Guid requesterId, UserRole requestingRole);
        public Task<DTOs.User.UserViewDTO?> DeleteUserAsync(Guid id, Guid requesterId, UserRole requestingRole);
    }
}
