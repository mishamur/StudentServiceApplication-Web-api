namespace StudentServiceApplication.Models
{
    public class Interes
    {
        public Guid InteresId { get; set; }
        public string Name { get; set; }

        public ICollection<UserInteres> UserInterests { get; set; } = new List<UserInteres>();
    }
}
