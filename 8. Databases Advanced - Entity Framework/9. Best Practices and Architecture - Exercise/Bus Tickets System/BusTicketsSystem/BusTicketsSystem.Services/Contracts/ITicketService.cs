using BusTicketsSystem.Models;

namespace BusTicketsSystem.Services.Contracts
{
    public interface ITicketService
    {
        Ticket BuyTicket(int customerId, int tripId, decimal price, string seat);
        TModel ById<TModel>(int id);
        bool Exist(int id);
    }
}
