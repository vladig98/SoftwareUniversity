using BusTicketsSystem.Models;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class BusStationsInitializer
    {
        public static BusStation[] GetBusStations()
        {
            BusStation[] busStations = new BusStation[]
            {
                new BusStation() { Name = "East Acton", TownId = 1 },
                new BusStation() { Name = "Aldwych", TownId = 2 },
                new BusStation() { Name = "Fulham Town Hall", TownId = 3 },
                new BusStation() { Name = "Dulwich Library", TownId = 4 },
                new BusStation() { Name = "Brent Park", TownId = 5 },
                new BusStation() { Name = "Archway tube station", TownId = 6 },
                new BusStation() { Name = "Oxford Circus", TownId = 7 },
                new BusStation() { Name = "Hackney Wick", TownId = 8 },
                new BusStation() { Name = "Camden Town", TownId = 9 },
                new BusStation() { Name = "Peckham", TownId = 10 }
            };

            return busStations;
        }
    }
}
