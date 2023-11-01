using Eventures.DbModels;
using Eventures.Models;

namespace Eventures.Services.Contracts
{
    public interface IEventsService
    {
        EventuresEvent GetEventById(string Id);
        IQueryable<EventuresEvent> GetAllEvents();
        IQueryable<EventuresEvent> GetAllBuyableEvents();
        bool EventExists(string Id);
        EventuresEvent AddEvent(EventViewModel model);
    }
}
