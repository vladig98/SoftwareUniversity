using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrafficLights
{
    public class TrafficLight
    {
        public string Color { get; private set; }
        private List<string> PossibleColors => new List<string> { "Red", "Green", "Yellow" };

        public TrafficLight(string color)
        {
            Color = color;
        }

        public void UpdateColor()
        {
            int index = PossibleColors.IndexOf(Color);

            Color = PossibleColors[(index + 1) % PossibleColors.Count];
        }
    }
}
