using Eventures.DbModels;
using Eventures.Filters;
using Eventures.Models;
using Eventures.Services.Contracts;
using Eventures.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Controllers
{
    public class OrdersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IOrdersService _ordersService;
        private readonly IEventsService _eventsService;

        public OrdersController(UserManager<User> userManager, IOrdersService ordersService, IEventsService eventsService)
        {
            _userManager = userManager;
            _ordersService = ordersService;
            _eventsService = eventsService;

        }

        [HttpPost]
        [Authorize]
        [TypeFilter(typeof(ValidModelStateActionFilter))]
        public async Task<IActionResult> Order(string eventId, OrderViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (model.Tickets < 1)
            {
                return BadRequest();
            }

            var eventuresEvent = _eventsService.GetEventById(eventId);

            if (eventuresEvent == null)
            {
                return BadRequest();
            }

            if (eventuresEvent.TotalTickets - model.Tickets < 0)
            {
                return BadRequest();
            }

            _ordersService.AddOrder(model, eventId, user.Id);

            return Redirect("/Events/MyEvents");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> All(int? pageNumber = 1)
        {
            var orders = _ordersService.GetAllOrders();

            int pageSize = 5;

            var pagedOrders = await PaginatedList<Order>.CreateAsync(orders, pageNumber ?? 1, pageSize);

            return View(pagedOrders);
        }
    }
}
