using Eventures.DbModels;
using Eventures.Models;

namespace Eventures.Services.Contracts
{
    public interface IOrdersService
    {
        Order GetOrderById(string Id);
        IQueryable<Order> GetAllOrders();
        IQueryable<Order> GetAllOrdersForUser(string userId);
        bool OrderExists(string Id);
        Order AddOrder(OrderViewModel model, string eventId, string userId);
    }
}
