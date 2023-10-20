using Eventures.DbModels;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            EventuresEvents = new HashSet<EventuresEvent>();
            Tickets = 1;
        }

        [Display(Name = "Tickets")]
        public int Tickets { get; set; }

        public ICollection<EventuresEvent> EventuresEvents { get; set; }
    }
}
