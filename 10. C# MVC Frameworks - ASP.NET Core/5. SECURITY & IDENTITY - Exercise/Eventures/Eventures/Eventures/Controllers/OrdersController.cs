using Eventures.Data;
using Eventures.DbModels;
using Eventures.Filters;
using Eventures.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Controllers
{
    public class OrdersController : Controller
    {
        private readonly EventuresDbContext _context;
        private readonly UserManager<User> _userManager;

        public OrdersController(EventuresDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        [TypeFilter(typeof(AuthenticatedActionFilter))]
        [TypeFilter(typeof(ValidModelStateActionFilter))]
        public async Task<IActionResult> Order(string eventId, OrderViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (model.Tickets < 1)
            {
                return BadRequest();
            }

            var eventuresEvent = _context.EventuresEvents.FirstOrDefault(x => x.Id == eventId);

            if (eventuresEvent == null)
            {
                return BadRequest();
            }

            if (eventuresEvent.TotalTickets - model.Tickets < 0)
            {
                return BadRequest();
            }

            var order = new Order
            {
                CustomerId = user.Id.ToString(),
                EventuresEventId = eventId,
                Id = Guid.NewGuid().ToString(),
                TicketsCount = model.Tickets,
                OrderedOn = DateTime.UtcNow
            };

            eventuresEvent.TotalTickets -= model.Tickets;

            _context.Orders.Add(order);
            _context.SaveChanges();

            return Redirect("/Events/MyEvents");
        }

        [TypeFilter(typeof(AuthenticatedActionFilter))]
        [TypeFilter(typeof(IsAdminActionFilter))]
        public IActionResult All()
        {
            var orders = _context.Orders.Include(x => x.EventuresEvent).Include(x => x.Customer).ToList();

            return View(orders);
        }
    }
}
