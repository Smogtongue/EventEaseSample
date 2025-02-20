using EventEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>
        {
            new Event { Id = 1, Name = "Corporate Meeting", Date = DateTime.Now.AddDays(10), Location = "New York", Description = "A meeting for corporate executives to discuss company strategy and goals.", PresentedBy = "TechCorp Inc." },
            new Event { Id = 2, Name = "Social Gathering", Date = DateTime.Now.AddDays(20), Location = "Los Angeles", Description = "A casual social gathering for networking and relaxation.", PresentedBy = "Socialize LLC" }
        };

        public List<Event> GetEvents()
        {
            return events;
        }

        public Event? GetEventById(int id)
        {
            return events.FirstOrDefault(e => e.Id == id);
        }

        public void AddEvent(Event newEvent)
        {
            newEvent.Id = events.Max(e => e.Id) + 1;
            events.Add(newEvent);
        }
    }
}
