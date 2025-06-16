using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<Domain.Entities.User>> GetAllUsersAsync();
        public Task <Domain.Entities.User?> GetUserByIdAsync(Guid id);
        public Task<Domain.Entities.User> CreateUserAsync(Domain.Entities.User user);
        public Task<Domain.Entities.User?> UpdateUserAsync(Guid id, Domain.Entities.User user);
        public Task<Domain.Entities.User?> DeleteUserAsync(Guid id);
    }
}
