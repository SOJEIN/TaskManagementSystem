using TaskManagementSystem.Core.Interfaces;
using TaskManagementSystem.Core.Entities;
using TaskManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace TaskManagementSystem.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Role> GetRoleByIdAsync(int id)
        {
            return await _context.Roles.FindAsync(id);
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task AddRoleAsync(Role role)
        {
            await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoleAsync(Role role)
        {
            _context.Roles.Update(role);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(int id)
        {
            var role = await GetRoleByIdAsync(id);
            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
        }
    }
}
