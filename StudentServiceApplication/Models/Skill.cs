using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.Models
{
    public class Skill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SkillId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<User> Users { get; } = new List<User>();
    }
}
