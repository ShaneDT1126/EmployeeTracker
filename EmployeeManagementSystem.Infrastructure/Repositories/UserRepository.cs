using EmployeeManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Infrastructure.Repositories
{
    public class UserRepository : Application.Interfaces.Repositories.IUserRepository
    {
        private readonly ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Domain.Entities.User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
        public async Task<Domain.Entities.User?> GetUserByIdAsync(Guid id)
        {
            return await _context.Users
                .Include(u => u.Manager)
                .Include(u => u.Departments)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<Domain.Entities.User> CreateUserAsync(Domain.Entities.User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
        public async Task<Domain.Entities.User?> UpdateUserAsync(Guid id, Domain.Entities.User user)
        {
            var newUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (newUser != null)
            {
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.Email = user.Email;
                newUser.Password = user.Password;
                newUser.Role = user.Role;
                newUser.ManagerId = user.ManagerId;
                newUser.DepartmentId = user.DepartmentId;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }
        public async Task<Domain.Entities.User?> DeleteUserAsync(Guid id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return user;
            }
            
            return user;
        }
    }
}
