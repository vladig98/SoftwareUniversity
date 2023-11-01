using Eventures.DbModels;
using Eventures.Filters;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly ILogger _logger;
        private readonly UserManager<User> _userManager;
        private readonly IEventsService _eventsService;
        private readonly IOrdersService _ordersService;

        public EventsController(ILogger<EventsController> logger, UserManager<User> userManager, IEventsService eventsService, IOrdersService ordersService)
        {
            _logger = logger;
            _userManager = userManager;
            _eventsService = eventsService;
            _ordersService = ordersService;

        }

        [Authorize]
        public async Task<IActionResult> MyEvents(int? pageNumber = 1)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var orders = _ordersService.GetAllOrdersForUser(user.Id);

            int pageSize = 5;

            PaginatedList<Order> pagedOrders = await PaginatedList<Order>.CreateAsync(orders, pageNumber ?? 1, pageSize);

            return View(pagedOrders);
        }

        [Authorize]
        public async Task<IActionResult> All(int? pageNumber = 1)
        {
            var events = _eventsService.GetAllBuyableEvents();

            var model = new OrderViewModel();
            //model.EventuresEvents = events;

            int pageSize = 5;

            var pagedEvents = await PaginatedList<EventuresEvent>.CreateAsync(events, pageNumber ?? 1, pageSize);
            model.EventuresEvents = pagedEvents;

            return View(model);
        }

        [TypeFilter(typeof(AdminLoggerActionFilter))]
        [Authorize(Roles = "Admin")]
        [TypeFilter(typeof(ValidModelStateActionFilter))]
        [HttpPost]
        public async Task<IActionResult> Create(EventViewModel model)
        {
            var eventuresEvent = _eventsService.AddEvent(model);

            _logger.LogInformation($"Event {eventuresEvent.Name} created successfully!");

            string message = $"[{DateTime.UtcNow.ToString("dd/MMM/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}] Administrator" +
                             $" {User.Identity.Name} create event {eventuresEvent.Name} " +
                             $"({eventuresEvent.Start.ToString("dd/MMM/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)} / " +
                             $"{eventuresEvent.End.ToString("dd/MMM/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture)}).";

            ViewData["Message"] = message;

            return Redirect("/Events/All");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
