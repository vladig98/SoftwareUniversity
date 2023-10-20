using Eventures.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Eventures.Models
{
    public class EventViewModel
    {
        [Display(Prompt = "Iron Maiden - Hills of Rock")]
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Name { get; set; }

        [Display(Prompt = "Plovdiv, Bulgaria")]
        [Required(AllowEmptyStrings = false)]
        public string Place { get; set; }

        [Display(Prompt = "20-Jul-2018 22:00")]
        [Required]
        [ValidDateTime]
        public string Start { get; set; }

        [Display(Prompt = "20-Aug-2018 04:00")]
        [Required]
        [ValidDateTime]
        public string End { get; set; }

        [Display(Prompt = "1000")]
        [Required]
        [Range(1, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Display(Prompt = "150")]
        [Required]
        public decimal PricePerTicket { get; set; }
    }
}
