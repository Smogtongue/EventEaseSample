using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Pages.Models
{
    public class Event
    {
        [Required(ErrorMessage = "Event Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Event Date is required.")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Event Time is required.")]
        public TimeSpan? Time { get; set; }

        [Required(ErrorMessage = "Event Description is required.")]
        public string? Description { get; set; }
    }
}