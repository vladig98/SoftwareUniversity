using System.Collections.Generic;

namespace BusTicketsSystem.Models
{
    public class BusStation
    {
        public BusStation()
        {
            OriginTrips = new HashSet<Trip>();
            DestinationTrips = new HashSet<Trip>();
            ArrivedOriginTrips = new HashSet<ArrivedTrip>();
            ArrivedDestinationTrips = new HashSet<ArrivedTrip>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<Trip> OriginTrips { get; set; }
        public ICollection<Trip> DestinationTrips { get; set; }
        public ICollection<ArrivedTrip> ArrivedOriginTrips { get; set; }
        public ICollection<ArrivedTrip> ArrivedDestinationTrips { get; set; }
    }
}
