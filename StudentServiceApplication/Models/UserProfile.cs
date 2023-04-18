using Microsoft.EntityFrameworkCore;

namespace StudentServiceApplication.Models
{
    [Owned]
    public class UserProfile
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DateOfBirthday { get; set; }
        public bool? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[]? ProfileImage { get; set; }
        public Guid InstituteId { get; set; }
        public Institute Institute { get; set; } = null!;

    }
}
