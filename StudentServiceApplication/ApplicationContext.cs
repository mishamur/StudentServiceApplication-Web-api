using Microsoft.EntityFrameworkCore;
using StudentServiceApplication.Models;

namespace StudentServiceApplication
{
    public class ApplicationContext :DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
