using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Event Name is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Event Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Event Location is required")]
        public required string Location { get; set; }

        [Required(ErrorMessage = "Event Description is required")]
        public required string Description { get; set; }
    }
}
