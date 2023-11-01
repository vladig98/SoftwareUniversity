using AutoMapper;
using Eventures.Data;
using Eventures.DbModels;
using Eventures.Models;
using Eventures.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly EventuresDbContext _context;
        private readonly IMapper _mapper;

        public OrdersService(EventuresDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Order GetOrderById(string Id) => _context.Orders.FirstOrDefault(x => x.Id == Id);

        public IQueryable<Order> GetAllOrders() => _context.Orders.Include(x => x.Customer).Include(x => x.EventuresEvent);
        public IQueryable<Order> GetAllOrdersForUser(string userId) => _context.Orders.Include(x => x.Customer).Include(x => x.EventuresEvent).Where(x => x.CustomerId == userId);

        public bool OrderExists(string Id) => _context.Orders.Any(x => x.Id == Id);

        public Order AddOrder(OrderViewModel model, string eventId, string userId)
        {
            Order order = _mapper.Map<OrderViewModel, Order>(model);

            order.EventuresEventId = eventId;
            order.CustomerId = userId;

            var eventuresEvent = _context.EventuresEvents.FirstOrDefault(x => x.Id == eventId);

            eventuresEvent.TotalTickets -= model.Tickets;

            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }
    }
}
