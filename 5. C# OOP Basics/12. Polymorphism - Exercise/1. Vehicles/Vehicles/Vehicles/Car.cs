using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IVehicle
    {
        public double fuelQuantity { get; private set; }
        public double fuelConsumption { get; private set; }
        public void Drive(double km)
        {
            if (fuelQuantity - (km * fuelConsumption) <= 0)
            {
                Console.WriteLine("Car needs refueling");
                return;
            } 

            fuelQuantity -= km * fuelConsumption;
            Console.WriteLine($"Car travelled {km} km");
        }

        public void Refuel(double fuel)
        {
            fuelQuantity += fuel;
        }

        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.fuelConsumption += 0.9;
        }

        public override string ToString()
        {
            return $"Car: {fuelQuantity:F2}";
        }
    }
}
