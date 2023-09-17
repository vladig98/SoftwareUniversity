using System;

namespace BusTicketsSystem.Models
{
    public class ArrivedTrip
    {
        public int Id { get; set; }
        public DateTime ActualArrivalTime { get; set; }
        public int OriginBusStationId { get; set; }
        public BusStation OriginBusStation { get; set; }
        public int DestinationBusStationId { get; set; }
        public BusStation DestinationBusStation { get; set; }
        public int PassengersCount { get; set; }
    }
}
