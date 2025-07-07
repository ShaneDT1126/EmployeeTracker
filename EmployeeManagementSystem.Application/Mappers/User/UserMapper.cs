using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Mappers.User
{
    public static class UserMapper
    {
        public static DTOs.User.UserViewDTO ToEmployeeUserViewDTO (this Domain.Entities.User user)
        {
            return new DTOs.User.UserViewDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                DepartmentName = user.Departments?.Name ?? string.Empty,
                ManagerName = user.Manager != null ? $"{user.Manager.FirstName} {user.Manager.LastName}" : string.Empty,
            };
        }

        public static DTOs.User.UserViewDTO ToManagerUserViewDTO(this Domain.Entities.User user)
        {
            return new DTOs.User.UserViewDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                DepartmentName = user.Departments?.Name ?? string.Empty,
                ManagerName = user.Manager != null ? $"{user.Manager.FirstName} {user.Manager.LastName}" : string.Empty,

            };
        }

        public static DTOs.User.UserViewDTO ToAdminUserViewDTO(this Domain.Entities.User user)
        {
            return new DTOs.User.UserViewDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                ManagerName = user.Manager != null ? $"{user.Manager.FirstName} {user.Manager.LastName}" : string.Empty,
                DepartmentName = user.Departments?.Name ?? string.Empty
            };
        }

        public static DTOs.User.UserCreateDTO ToAdminUserCreateDTO(this Domain.Entities.User user)
        {
            return new DTOs.User.UserCreateDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                ManagerId = user.ManagerId,
                DepartmentId = user.DepartmentId
            };
        }

        public static Domain.Entities.User ToAdminUserCreateEntity(this DTOs.User.UserUpdateDTO userDto)
        {
            return new Domain.Entities.User
            {
                Id = userDto.Id, 
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                Role = userDto.Role,
                CreatedAt = userDto.CreatedAt,
                ManagerId = userDto.ManagerId,
                DepartmentId = userDto.DepartmentId
            };
        }
    }
}
