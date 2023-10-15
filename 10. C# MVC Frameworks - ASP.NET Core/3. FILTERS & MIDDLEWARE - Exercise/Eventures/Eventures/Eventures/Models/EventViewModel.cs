using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class EventViewModel
    {
        [Display(Prompt = "Iron Maiden - Hills of Rock")]
        public string Name { get; set; }

        [Display(Prompt = "Plovdiv, Bulgaria")]
        public string Place { get; set; }

        [Display(Prompt = "20-Jul-2018 22:00")]
        public string Start { get; set; }

        [Display(Prompt = "20-Aug-2018 04:00")]
        public string End { get; set; }

        [Display(Prompt = "1000")]
        public int TotalTickets { get; set; }

        [Display(Prompt = "150")]
        public decimal PricePerTicket { get; set; }
    }
}
