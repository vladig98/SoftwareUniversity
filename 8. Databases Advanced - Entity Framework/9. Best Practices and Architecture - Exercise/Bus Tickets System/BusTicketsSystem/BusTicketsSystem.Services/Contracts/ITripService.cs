using BusTicketsSystem.Models;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Services.Contracts
{
    public interface ITripService
    {
        TModel ById<TModel>(int id);
        bool Exist(int id);
        ArrivedTrip UpdateStatus(int tripId, Status status);
    }
}
