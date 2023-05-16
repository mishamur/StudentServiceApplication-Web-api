using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentServiceApplication.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MessageId { get; set; }
        public Guid SenderId { get; set; }
        public User? Sender { get; set; }
        public Guid RecepientId { get; set; }
        public User? Recepient { get; set; }
        public string? MessageText { get; set; }
        public DateTime DateSent { get; set; }

    }
}
