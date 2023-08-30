using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        private string color;

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        private int battery;

        public int Battery
        {
            get
            {
                return battery;
            }
            set
            {
                battery = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public override string ToString()
        {
            return $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
        }
    }
}
