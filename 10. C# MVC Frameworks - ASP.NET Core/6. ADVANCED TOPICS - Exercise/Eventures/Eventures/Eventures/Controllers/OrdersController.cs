using AutoMapper;
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
        private readonly IMapper _mapper;

        public OrdersController(EventuresDbContext context, UserManager<User> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
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

            Order order = _mapper.Map<OrderViewModel, Order>(model);

            order.EventuresEventId = eventuresEvent.Id;
            order.CustomerId = user.Id;

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
