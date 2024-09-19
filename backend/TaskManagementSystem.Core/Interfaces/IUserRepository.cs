using TaskManagementSystem.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManagementSystem.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
    }
}
