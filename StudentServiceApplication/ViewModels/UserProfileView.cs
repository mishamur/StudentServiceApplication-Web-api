using StudentServiceApplication.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.ViewModels
{
    public class UserProfileView
    {
        public Guid UserId { get; set; }
        [Required]
        public UserProfile? UserProfile { get; set; }
        public Guid CountryId { get; set; }
        public Guid InstituteId { get; set; }
        public ICollection<Guid> HavingSkills { get; set; } = new List<Guid>();
        public ICollection<Guid> NeedingSkills { get; set; } = new List<Guid>();
        public ICollection<Guid> Languages { get; set; } = new List<Guid>();
        public ICollection<Guid> Interests { get; set; } = new List<Guid>();
    }
}
