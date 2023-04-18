using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentServiceApplication.Models
{
    public class Interes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid InteresId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<User> UsersProfiles { get; } = new List<User>();
    }
}
