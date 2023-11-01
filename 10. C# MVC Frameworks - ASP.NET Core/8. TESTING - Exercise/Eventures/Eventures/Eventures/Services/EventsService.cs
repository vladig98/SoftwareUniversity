using AutoMapper;
using Eventures.Data;
using Eventures.DbModels;
using Eventures.Models;
using Eventures.Services.Contracts;
using System.Globalization;

namespace Eventures.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventuresDbContext _context;
        private readonly IMapper _mapper;

        public EventsService(EventuresDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public EventuresEvent GetEventById(string Id) => _context.EventuresEvents.FirstOrDefault(x => x.Id == Id);

        public IQueryable<EventuresEvent> GetAllEvents() => _context.EventuresEvents;
        public IQueryable<EventuresEvent> GetAllBuyableEvents() => _context.EventuresEvents.Where(x => x.TotalTickets > 0);

        public bool EventExists(string Id) => _context.EventuresEvents.Any(x => x.Id == Id);

        public EventuresEvent AddEvent(EventViewModel model)
        {
            var startDate = ParseDate(model.Start);
            var endDate = ParseDate(model.End);

            var eventuresEvent = _mapper.Map<EventViewModel, EventuresEvent>(model);

            eventuresEvent.End = endDate;
            eventuresEvent.Start = startDate;

            _context.EventuresEvents.Add(eventuresEvent);
            _context.SaveChanges();

            return eventuresEvent;
        }

        private DateTime ParseDate(string value)
        {
            return DateTime.ParseExact(value, "dd-MMM-yyyy HH:mm", CultureInfo.InvariantCulture);
        }
    }
}
