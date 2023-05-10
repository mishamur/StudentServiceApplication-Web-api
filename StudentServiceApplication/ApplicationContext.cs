using Microsoft.EntityFrameworkCore;
using StudentServiceApplication.Models;

namespace StudentServiceApplication
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Interes> Interests { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Institute> Institutes { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<TranslatePhoto> TranslatePhotos { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
