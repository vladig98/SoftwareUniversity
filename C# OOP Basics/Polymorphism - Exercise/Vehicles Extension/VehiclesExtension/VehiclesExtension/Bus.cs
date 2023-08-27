using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus : IVehicle
    {
        public double fuelQuantity { get; private set; }
        public double fuelConsumption { get; private set; }
        public double tankCapacity { get; private set; }
        public void Drive(double km)
        {
            if (fuelQuantity - (km * fuelConsumption) <= 0)
            {
                Console.WriteLine($"Bus needs refueling");
                return;
            }

            fuelQuantity -= km * fuelConsumption;
            Console.WriteLine($"Bus travelled {km} km");
        }

        public void DriveEmpty(double km)
        {
            if (fuelQuantity - (km * (fuelConsumption - 1.4)) <= 0)
            {
                Console.WriteLine($"Bus needs refueling");
                return;
            }

            fuelQuantity -= km * (fuelConsumption - 1.4);
            Console.WriteLine($"Bus travelled {km} km");
        }

        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (fuelQuantity + fuel > tankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                return;
            }
            fuelQuantity += fuel;
        }

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelConsumption = fuelConsumption;
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = fuelQuantity;
            }
            this.tankCapacity = tankCapacity;
            this.fuelConsumption += 1.4;
        }

        public override string ToString()
        {
            return $"Bus: {fuelQuantity:F2}";
        }
    }
}
