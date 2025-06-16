using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Mappers.User
{
    public static class UserMapper
    {
        public static DTOs.User.UserDTO ToEmployeeUserDTO (this Domain.Entities.User user)
        {
            return new DTOs.User.UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };
        }

        public static DTOs.User.UserDTO ToManagerUserDTO(this Domain.Entities.User user)
        {
            return new DTOs.User.UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                ManagerId = user.ManagerId,
                DepartmentId = user.DepartmentId
            };
        }

        public static DTOs.User.UserDTO ToAdminUserDTO(this Domain.Entities.User user)
        {
            return new DTOs.User.UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role,
                CreatedAt = user.CreatedAt,
                ManagerId = user.ManagerId,
                DepartmentId = user.DepartmentId
            };
        }

        public static Domain.Entities.User ToUserEntity(this DTOs.User.UserDTO userDto)
        {
            return new Domain.Entities.User
            {
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
