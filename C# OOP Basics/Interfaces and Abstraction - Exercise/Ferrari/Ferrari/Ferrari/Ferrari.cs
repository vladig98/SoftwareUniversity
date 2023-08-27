using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string Model { get; private set; }
        public string Driver { get; set; }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public Ferrari(string driver)
        {
            Driver = driver;
            Model = "488-Spider";
        }

        public override string ToString()
        {
            return string.Format($"{Model}/{UseBrakes()}/{PushGasPedal()}/{Driver}");
        }
    }
}
