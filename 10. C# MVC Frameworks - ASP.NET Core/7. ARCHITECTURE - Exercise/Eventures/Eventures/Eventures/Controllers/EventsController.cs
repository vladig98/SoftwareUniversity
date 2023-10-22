using AutoMapper;
using Eventures.Data;
using Eventures.DbModels;
using Eventures.Filters;
using Eventures.Models;
using Eventures.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventuresDbContext _context;
        private readonly ILogger _logger;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public EventsController(EventuresDbContext context, ILogger<EventsController> logger, UserManager<User> userManager, IMapper mapper)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
            _mapper = mapper;
        }

        [TypeFilter(typeof(AuthenticatedActionFilter))]
        public async Task<IActionResult> MyEvents(int? pageNumber = 1)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var orders = _context.Orders.Include(x => x.EventuresEvent).Where(x => x.CustomerId == user.Id);

            int pageSize = 5;

            PaginatedList<Order> pagedOrders = await PaginatedList<Order>.CreateAsync(orders, pageNumber ?? 1, pageSize);

            return View(pagedOrders);
        }

        [TypeFilter(typeof(AuthenticatedActionFilter))]
        public async Task<IActionResult> All(int? pageNumber = 1)
        {
            var events = _context.EventuresEvents.Where(x => x.TotalTickets > 0);

            var model = new OrderViewModel();
            //model.EventuresEvents = events;

            int pageSize = 5;

            var pagedEvents = await PaginatedList<EventuresEvent>.CreateAsync(events, pageNumber ?? 1, pageSize);
            model.EventuresEvents = pagedEvents;

            return View(model);
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

            EventuresEvent eventuresEvent = _mapper.Map<EventViewModel, EventuresEvent>(model);
            eventuresEvent.End = endDate;
            eventuresEvent.Start = startDate;

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
