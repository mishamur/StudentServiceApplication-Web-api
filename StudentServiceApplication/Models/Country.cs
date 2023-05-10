using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CountryId { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
