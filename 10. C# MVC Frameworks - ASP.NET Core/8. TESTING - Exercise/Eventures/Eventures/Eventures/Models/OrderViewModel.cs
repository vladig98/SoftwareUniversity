using Eventures.DbModels;
using Eventures.Utilities;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            var eventuresEvent = new EventuresEvent();
            EventuresEvents = new PaginatedList<EventuresEvent>(new List<EventuresEvent> { eventuresEvent }, 1, 1, 1);
            Tickets = 1;
            Id = Guid.NewGuid().ToString();
            OrderedOn = DateTime.UtcNow;
        }

        [Display(Name = "Tickets")]
        public int Tickets { get; set; }

        public PaginatedList<EventuresEvent> EventuresEvents { get; set; }

        public DateTime OrderedOn { get; set; }
        public string Id { get; set; }
    }
}
