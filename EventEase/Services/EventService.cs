#nullable enable

using EventEase.Pages.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEase.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>();

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(events);
        }

        public Task AddEventAsync(Event eventModel)
        {
            events.Add(eventModel);
            return Task.CompletedTask;
        }
    }
}
