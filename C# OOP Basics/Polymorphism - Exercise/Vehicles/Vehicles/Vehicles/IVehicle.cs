using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        double fuelQuantity { get; }
        double fuelConsumption { get; }

        void Drive(double km);
        void Refuel(double fuel);
    }
}
