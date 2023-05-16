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
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<Skill> WantedSkills { get; set; } = null!;
        public DbSet<TranslatePhoto> TranslatePhotos { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
              .HasOne(m => m.Sender)
              .WithMany(u => u.SentMessage)
              .HasForeignKey(m => m.SenderId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Recepient)
                .WithMany(u => u.ReceivedMessage)
                .HasForeignKey(m => m.RecepientId);

            modelBuilder.Entity<Skill>()
                .ToTable("HavingSkill")
                .HasMany(s => s.HavingUsers)
                .WithMany(u => u.Skills);
            
            modelBuilder.Entity<Skill>()
                .ToTable("WantedSkill")
                .HasMany(s => s.NeedingUsers)
                .WithMany(u => u.WantedSkills);
        }
    }
}
