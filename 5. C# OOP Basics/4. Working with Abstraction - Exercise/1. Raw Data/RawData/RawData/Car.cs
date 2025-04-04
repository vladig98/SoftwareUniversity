﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, 
            double tire2Pressure, int tire2Age, double tire3Pressure, int tire3age, double tire4Pressure, int tire4age)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = new List<Tire>();
            Tires.Add(new Tire(tire1Pressure, tire1Age));
            Tires.Add(new Tire(tire2Pressure, tire2Age));
            Tires.Add(new Tire(tire3Pressure, tire3age));
            Tires.Add(new Tire(tire4Pressure, tire4age));
        }
    }
}
