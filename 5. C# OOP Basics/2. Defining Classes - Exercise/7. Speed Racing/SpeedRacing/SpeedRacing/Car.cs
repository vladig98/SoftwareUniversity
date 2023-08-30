using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerOneKilometer { get; set; }
        public double DistanceTravelled { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerOneKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerOneKilometer = fuelConsumptionPerOneKilometer;
            DistanceTravelled = 0;
        }

        public void Drive(double amountOfKilometers)
        {
            if (FuelAmount >= amountOfKilometers * FuelConsumptionPerOneKilometer)
            {
                FuelAmount -= amountOfKilometers * FuelConsumptionPerOneKilometer;
                DistanceTravelled += amountOfKilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {DistanceTravelled}";
        }
    }
}
