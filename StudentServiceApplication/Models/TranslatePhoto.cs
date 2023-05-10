using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentServiceApplication.Models
{
    public class TranslatePhoto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        [Required]
        public byte[]? OriginalImage { get; set; }
        [Required]
        public byte[]? TranslateImage { get; set; }
    }
}
