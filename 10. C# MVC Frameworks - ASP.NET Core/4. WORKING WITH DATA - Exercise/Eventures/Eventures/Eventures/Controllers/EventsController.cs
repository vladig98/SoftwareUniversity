using Eventures.Data;
using Eventures.DbModels;
using Eventures.Filters;
using Eventures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventuresDbContext _context;
        private readonly ILogger _logger;

        public EventsController(EventuresDbContext context, ILogger<EventsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [TypeFilter(typeof(AuthenticatedActionFilter))]
        public IActionResult All()
        {
            var events = _context.EventuresEvents.ToList();

            return View(events);
        }

        [TypeFilter(typeof(AdminLoggerActionFilter))]
        [TypeFilter(typeof(AuthenticatedActionFilter))]
        [TypeFilter(typeof(IsAdminActionFilter))]
        [TypeFilter(typeof(ValidModelStateActionFilter))]
        [HttpPost]
        public async Task<IActionResult> Create(EventViewModel model)
        {
            var startDate = ParseDate(model.Start);
            var endDate = ParseDate(model.End);

            EventuresEvent eventuresEvent = new EventuresEvent
            {
                End = endDate,
                Id = Guid.NewGuid().ToString(),
                Start = startDate,
                Name = model.Name,
                Place = model.Place,
                PricePerTicket = model.PricePerTicket,
                TotalTickets = model.TotalTickets
            };

            _context.EventuresEvents.Add(eventuresEvent);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Event {eventuresEvent.Name} created successfully!");

            string message = $"[{DateTime.UtcNow.ToString("dd/MMM/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}] Administrator" +
                             $" {User.Identity.Name} create event {eventuresEvent.Name} " +
                             $"({eventuresEvent.Start.ToString("dd/MMM/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)} / " +
                             $"{eventuresEvent.End.ToString("dd/MMM/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}).";

            ViewData["Message"] = message;

            return Redirect("/Events/All");
        }

        private DateTime ParseDate(string value)
        {
            return DateTime.ParseExact(value, "dd-MMM-yyyy HH:mm", CultureInfo.InvariantCulture);
        }

        [TypeFilter(typeof(AuthenticatedActionFilter))]
        [TypeFilter(typeof(IsAdminActionFilter))]
        public IActionResult Create()
        {
            return View();
        }
    }
}
