using Microsoft.EntityFrameworkCore;

namespace StudentServiceApplication.Models
{
    [Owned]
    public class UserProfile
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Description { get; set; }
        public byte? Course { get; set; }
        public string? StudyDirection { get; set; }
        public DateTime? DateOfBirthday { get; set; }
        public bool? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[]? ProfileImage { get; set; }
    }
}
    