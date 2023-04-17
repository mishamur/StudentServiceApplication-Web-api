using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using StudentServiceApplication.Models;

namespace StudentServiceApplication
{
    public class ApplicationContext :DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Interes> Interests { get; set; } = null!;
        public DbSet<UserInteres> UsersInteres { get; set; } = null!;
        public DbSet<Language> Languages { get; set; } = null!;
        public DbSet<UserLanguages> UserLanguages { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInteres>()
                .HasKey(k => new { k.InteresId, k.UserId });
            modelBuilder.Entity<UserLanguages>()
                .HasKey(k => new { k.LanguageId, k.UserId });
        }
    }
}
