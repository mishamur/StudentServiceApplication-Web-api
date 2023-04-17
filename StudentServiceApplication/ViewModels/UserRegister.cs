using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.ViewModels
{
    public class UserRegister
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConformPassword { get; set; }
    }
}
