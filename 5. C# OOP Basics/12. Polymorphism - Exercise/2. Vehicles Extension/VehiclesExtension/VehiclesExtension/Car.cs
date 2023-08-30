using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car : IVehicle
    {
        public double fuelQuantity { get; private set; }
        public double fuelConsumption { get; private set; }
        public double tankCapacity { get; private set; }
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

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = fuelQuantity;
            }
            this.tankCapacity = tankCapacity;
            this.fuelConsumption = fuelConsumption;
            this.fuelConsumption += 0.9;
        }

        public override string ToString()
        {
            return $"Car: {fuelQuantity:F2}";
        }
    }
}
