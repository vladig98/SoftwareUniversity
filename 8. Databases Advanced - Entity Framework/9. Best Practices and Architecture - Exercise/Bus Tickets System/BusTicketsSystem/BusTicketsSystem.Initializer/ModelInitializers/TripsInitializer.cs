using BusTicketsSystem.Models;
using BusTicketsSystem.Models.Enums;
using System;
using System.Globalization;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class TripsInitializer
    {
        public static Trip[] GetTrips()
        {
            Trip[] trips = new Trip[]
            {
                new Trip() { ArrivalTime = DateTime.ParseExact("20/09/2023 14:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture), 
                    DepartureTime = DateTime.ParseExact("20/09/2023 15:10:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 1, DestinationBusStationId = 10, OriginBusStationId = 1, Status = Status.Delayed },
                new Trip() { ArrivalTime = null, DepartureTime = null,
                    BusCompanyId = 2, DestinationBusStationId = 9, OriginBusStationId = 2, Status = Status.Cancelled },
                new Trip() { ArrivalTime = DateTime.ParseExact("21/09/2023 14:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    DepartureTime = DateTime.ParseExact("21/09/2023 15:05:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 3, DestinationBusStationId = 8, OriginBusStationId = 3, Status = Status.Delayed },
                new Trip() { ArrivalTime = DateTime.ParseExact("19/09/2023 14:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    DepartureTime = DateTime.ParseExact("19/09/2023 16:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 4, DestinationBusStationId = 7, OriginBusStationId = 4, Status = Status.Delayed },
                new Trip() { ArrivalTime = DateTime.ParseExact("20/09/2023 14:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    DepartureTime = DateTime.ParseExact("20/09/2023 15:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 5, DestinationBusStationId = 6, OriginBusStationId = 5, Status = Status.Arrived },
                new Trip() { ArrivalTime = DateTime.ParseExact("20/09/2023 16:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    DepartureTime = DateTime.ParseExact("20/09/2023 16:30:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 6, DestinationBusStationId = 5, OriginBusStationId = 6, Status = Status.Arrived },
                new Trip() { ArrivalTime = null, DepartureTime = null,
                    BusCompanyId = 7, DestinationBusStationId = 4, OriginBusStationId = 7, Status = Status.Cancelled },
                new Trip() { ArrivalTime = DateTime.ParseExact("20/09/2023 12:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    DepartureTime = DateTime.ParseExact("20/09/2023 13:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 8, DestinationBusStationId = 3, OriginBusStationId = 8, Status = Status.Arrived },
                new Trip() { ArrivalTime = DateTime.ParseExact("20/09/2023 13:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    DepartureTime = DateTime.ParseExact("20/09/2023 15:00:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    BusCompanyId = 9, DestinationBusStationId = 2, OriginBusStationId = 9, Status = Status.Arrived },
                new Trip() { ArrivalTime = null, DepartureTime = null,
                    BusCompanyId = 10, DestinationBusStationId = 1, OriginBusStationId = 10, Status = Status.Cancelled },
            };

            return trips;
        }
    }
}
