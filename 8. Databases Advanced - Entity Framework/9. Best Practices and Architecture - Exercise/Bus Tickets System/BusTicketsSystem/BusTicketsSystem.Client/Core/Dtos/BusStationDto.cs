using BusTicketsSystem.Models;
using System.Collections.Generic;

namespace BusTicketsSystem.Client.Core.Dtos
{
    public class BusStationDto
    {
        public BusStationDto()
        {
            OriginTrips = new HashSet<TripDto>();
            DestinationTrips = new HashSet<TripDto>();
        }

        public string Name { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }
        public ICollection<TripDto> OriginTrips { get; set; }
        public ICollection<TripDto> DestinationTrips { get; set; }
    }
}
