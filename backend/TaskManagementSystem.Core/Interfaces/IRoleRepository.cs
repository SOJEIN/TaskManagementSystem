using TaskManagementSystem.Core.Entities;

namespace TaskManagementSystem.Core.Interfaces
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleByIdAsync(int id);
        Task<IEnumerable<Role>> GetAllRolesAsync();
        Task AddRoleAsync(Role role);
        Task UpdateRoleAsync(Role role);
        Task DeleteRoleAsync(int id);
    }
}
