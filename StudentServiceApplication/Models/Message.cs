using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.Models
{
    public class Message
    {
        [Key]
        public Guid MessageId { get; set; }
        public Guid SenderId { get; set; }
        public User? Sender { get; set; }
        public Guid RecepientId { get; set; }
        public User? Recepient { get; set; }
        public string? MessageText { get; set; }
        public DateTime DateSent { get; set; }

    }
}
