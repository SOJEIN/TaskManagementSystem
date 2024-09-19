using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Core.Entities;
using TaskManagementSystem.Core.Interfaces;
using TaskManagementSystem.Infrastructure.Data;

namespace TaskManagementSystem.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserTask> GetTaskByIdAsync(int id)
        {
            return await _context.UserTasks.FindAsync(id);
        }

        public async Task<IEnumerable<UserTask>> GetAllTasksAsync()
        {
            return await _context.UserTasks.ToListAsync();
        }

        public async Task AddTaskAsync(UserTask task) // Cambiado a AddTaskAsync
        {
            await _context.UserTasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(UserTask task) // Cambiado a UpdateTaskAsync
        {
            _context.UserTasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id) // Cambiado a DeleteTaskAsync
        {
            var task = await _context.UserTasks.FindAsync(id);
            if (task != null)
            {
                _context.UserTasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }
    }
}
