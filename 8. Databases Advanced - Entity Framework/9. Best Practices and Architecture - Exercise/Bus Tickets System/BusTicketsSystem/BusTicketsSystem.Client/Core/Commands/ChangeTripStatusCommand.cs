using BusTicketsSystem.Client.Core.Contracts;
using BusTicketsSystem.Client.Core.Dtos;
using BusTicketsSystem.Models.Enums;
using BusTicketsSystem.Services.Contracts;
using System;
using System.Globalization;
using System.Text;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class ChangeTripStatusCommand : ICommand
    {
        private readonly ITripService tripService;

        public ChangeTripStatusCommand(ITripService tripService)
        {
            this.tripService = tripService;
        }

        public string Execute(string[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException("Invalid data!");
            }

            var isTripIdValid = int.TryParse(args[0], out int tripId);
            var isStatusValid = Enum.TryParse(args[1], true, out Status status);

            if (!isTripIdValid || !isStatusValid)
            {
                throw new ArgumentException("Invalid data!");
            }

            var tripExists = tripService.Exist(tripId);

            if (!tripExists)
            {
                throw new ArgumentException("Trip not found!");
            }

            var trip = tripService.ById<TripDto>(tripId);
            var arrivedTrip = tripService.UpdateStatus(tripId, status);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Trip from {trip.OriginBusStation.Name} to {trip.DestinationBusStation.Name} on " +
                $"{trip.DepartureTime.Value.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Status changed from {trip.Status} to {status}");

            if (arrivedTrip != null)
            {
                sb.AppendLine($"On {arrivedTrip.ActualArrivalTime.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture)}" +
                    $" - {arrivedTrip.PassengersCount} passengers arrived at {arrivedTrip.DestinationBusStation.Name} from " +
                    $"{arrivedTrip.OriginBusStation.Name}");
            }

            return sb.ToString();
        }
    }
}
