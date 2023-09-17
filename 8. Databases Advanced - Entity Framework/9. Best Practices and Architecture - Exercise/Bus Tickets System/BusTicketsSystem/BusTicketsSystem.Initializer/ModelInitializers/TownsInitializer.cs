using BusTicketsSystem.Models;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class TownsInitializer
    {
        public static Town[] GetTowns()
        {
            Town[] towns = new Town[]
            {
                new Town() { Name = "London", Country = "United Kingdom" },
                new Town() { Name = "Belfast", Country = "United Kingdom" },
                new Town() { Name = "Bradford", Country = "United Kingdom" },
                new Town() { Name = "Manchester", Country = "United Kingdom" },
                new Town() { Name = "Bristol", Country = "United Kingdom" },
                new Town() { Name = "Chester", Country = "United Kingdom" },
                new Town() { Name = "Liverpool", Country = "United Kingdom" },
                new Town() { Name = "Norwich", Country = "United Kingdom" },
                new Town() { Name = "Oxford", Country = "United Kingdom" },
                new Town() { Name = "Sheffield", Country = "United Kingdom" }
            };

            return towns;
        }
    }
}
