using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.Models
{
    public class UserLanguages
    {
        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
        [Required]
        public Guid LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
