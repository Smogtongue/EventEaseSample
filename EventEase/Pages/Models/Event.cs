// Pages/Models/Event.cs
namespace EventEase.Pages.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Date { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; } // Nullable property
    }
}
