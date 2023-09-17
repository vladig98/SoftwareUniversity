using BusTicketsSystem.Models.Enums;
using BusTicketsSystem.Models;
using System;

namespace BusTicketsSystem.Client.Core.Dtos
{
    public class TripDto
    {
        public DateTime? ArrivalTime { get; set; }
        public Status Status { get; set; }
        public int OriginBusStationId { get; set; }
        public BusStation OriginBusStation { get; set; }
        public int DestinationBusStationId { get; set; }
        public BusStation DestinationBusStation { get; set; }
        public DateTime? DepartureTime { get; set; }
    }
}
