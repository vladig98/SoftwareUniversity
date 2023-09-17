using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusTicketsSystem.Models
{
    public class BusCompany
    {
        public BusCompany()
        {
            Reviews = new HashSet<Review>();
            Trips = new HashSet<Trip>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        [Range(1, 10)]
        public double Rating { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Trip> Trips { get; set; }
    }
}
