using BusTicketsSystem.Client.Core.Contracts;
using BusTicketsSystem.Client.Core.Dtos;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Contracts;
using System;
using System.Text;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class PrintInfoCommand : ICommand
    {
        private readonly IBusStationService busStationService;

        public PrintInfoCommand(IBusStationService busStationService)
        {
            this.busStationService = busStationService;
        }

        public string Execute(string[] args)
        {
            if (args.Length != 1)
            {
                throw new ArgumentException("Invalid data.");
            }

            bool isValid = int.TryParse(args[0], out int busStationId);

            if (!isValid)
            {
                throw new ArgumentException("Invalid data.");
            }

            if (!busStationService.Exist(busStationId))
            {
                throw new ArgumentException("Bus station not found!");
            }

            var busStation = busStationService.ById<BusStationDto>(busStationId);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{busStation.Name}, {busStation.Town.Name}");
            sb.AppendLine($"Arrivals:");

            foreach (var trip in busStation.DestinationTrips)
            {
                var time = trip.ArrivalTime.HasValue ? trip.ArrivalTime.Value.ToString("HH:mm") : "N\\A";

                sb.AppendLine($"From {trip.OriginBusStation.Name} | Arrive at: {time} | Status: {trip.Status}");
            }

            sb.AppendLine("Departures:");

            foreach (var trip in busStation.OriginTrips)
            {
                var time = trip.ArrivalTime.HasValue ? trip.ArrivalTime.Value.ToString("HH:mm") : "N\\A";

                sb.AppendLine($"To {trip.DestinationBusStation.Name} | Depart at: {time} | Status: {trip.Status}");
            }

            return sb.ToString();
        }
    }
}
