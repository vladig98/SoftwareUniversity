using Eventures.Data;
using Eventures.DbModels;
using Eventures.DbModels.Enums;
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

        public IActionResult All()
        {
            if (!User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is not authenticated!");
                return Redirect("/Home/Error");
            }

            var events = _context.EventuresEvents.ToList();

            return View(events);
        }

        [TypeFilter(typeof(AdminLoggerActionFilter))]
        [HttpPost]
        public async Task<IActionResult> Create(EventViewModel model)
        {
            if (!User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is not authenticated!");
                return Redirect("/Home/Error");
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                _logger.LogError("User is not an admin!");
                return Redirect("/Home/Error");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("The data is invalid!");
                return BadRequest();
            }

            var isStartValid = DateTime.TryParseExact(model.Start, "dd-MMM-yyyy HH:mm", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate);

            var isEndValid = DateTime.TryParseExact(model.End, "dd-MMM-yyyy HH:mm",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate);

            if (!isStartValid || !isEndValid)
            {
                _logger.LogError($"Cannot parse dates! start: {isEndValid} end: {isEndValid}");
                return BadRequest();
            }

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

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                _logger.LogError("User is not authenticated!");
                return Redirect("/Home/Error");
            }

            if (!User.IsInRole(Role.Admin.ToString()))
            {
                _logger.LogError("User is not an admin!");
                return Redirect("/Home/Error");
            }

            return View();
        }
    }
}
