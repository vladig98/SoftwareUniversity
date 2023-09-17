using System.Collections.Generic;

namespace BusTicketsSystem.Models
{
    public class Town
    {
        public Town()
        {
            BusStations = new HashSet<BusStation>();
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<BusStation> BusStations { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
