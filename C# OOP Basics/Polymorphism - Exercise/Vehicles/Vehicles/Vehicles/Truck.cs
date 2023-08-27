using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : IVehicle
    {
        public double fuelQuantity { get; private set; }
        public double fuelConsumption { get; private set; }
        public void Drive(double km)
        {
            if (fuelQuantity - (km * fuelConsumption) <= 0)
            {
                Console.WriteLine($"Truck needs refueling");
                return;
            }

            fuelQuantity -= km * fuelConsumption;
            Console.WriteLine($"Truck travelled {km} km");
        }

        public void Refuel(double fuel)
        {
            fuelQuantity += fuel * 0.95;
        }

        public Truck(double fuelQuantity, double fuelConsumption)
        {
            this.fuelConsumption = fuelConsumption;
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption += 1.6;
        }

        public override string ToString()
        {
            return $"Truck: {fuelQuantity:F2}";
        }
    }
}
