using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public Engine(string model, int power, string efficiency)
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            return $"  {Model}:\r\n    Power: {Power}\r\n    " +
                $"Displacement: {(Displacement == null ? "n/a" : Displacement.ToString())}\r\n    Efficiency: {(Efficiency == null ? "n/a" : Efficiency)}";
        }
    }
}
