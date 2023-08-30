using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public int Weight { get; set; }
        public CargoType Type { get; set; }

        public Cargo(int weight, CargoType type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
