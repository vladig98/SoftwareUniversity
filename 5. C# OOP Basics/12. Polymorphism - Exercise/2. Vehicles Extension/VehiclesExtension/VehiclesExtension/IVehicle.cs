using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public interface IVehicle
    {
        double fuelQuantity { get; }
        double fuelConsumption { get; }
        double tankCapacity { get; }

        void Drive(double km);
        void Refuel(double fuel);
    }
}
