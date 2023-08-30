using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public int CargoWeight { get; set; }
        public CargoType Type { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            Type = (CargoType)Enum.Parse(typeof(CargoType), cargoType);
        }
    }
}
