using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentServiceApplication.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }
        public UserProfile? UserProfile { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public Guid InstituteId { get; set; }
        public Institute Institute { get; set; } = null!;
        public ICollection<Skill> Skills { get; } = new List<Skill>();
        public ICollection<Skill> WantedSkills { get; } = new List<Skill>();
        public ICollection<Language> Languages { get; } = new List<Language>();
        public ICollection<Interes> Interests { get; } = new List<Interes>();
        public ICollection<TranslatePhoto> TranslatePhotos { get; } = new List<TranslatePhoto>();
        public ICollection<Message> SentMessage { get; } = new List<Message>();
        public ICollection<Message> ReceivedMessage { get; } = new List<Message>();
    }
}
