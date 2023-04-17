using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentServiceApplication.Models
{
    public class UserInteres
    {
        [Required]
        public Guid UserId { get; set; }
        public User? User { get; set; }
        [Required]
        public Guid InteresId { get; set; }
        public Interes? Interes { get; set; }
        
    }
}