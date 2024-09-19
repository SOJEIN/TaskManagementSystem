using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Core.Entities;

namespace TaskManagementSystem.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
    }
}