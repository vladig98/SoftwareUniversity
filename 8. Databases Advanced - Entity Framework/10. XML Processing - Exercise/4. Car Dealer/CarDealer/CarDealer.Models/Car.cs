using System.Collections.Generic;

namespace CarDealer.Models
{
    public class Car
    {
        public Car()
        {
            Parts = new HashSet<PartCar>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public ulong TraveledDistance { get; set; }
        public ICollection<PartCar> Parts { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
