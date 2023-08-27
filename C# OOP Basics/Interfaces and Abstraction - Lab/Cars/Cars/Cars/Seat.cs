using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
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

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Color} {this.GetType().Name} {Model}{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
        }
    }
}
