namespace EventEase.Pages.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
