namespace StudentServiceApplication.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecepientId { get; set; }
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }

        

    }
}
