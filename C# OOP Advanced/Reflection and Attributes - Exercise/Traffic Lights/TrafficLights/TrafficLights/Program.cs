using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficLights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] trafficLightsTokens = Console.ReadLine().Split(' ');

            List<TrafficLight> trafficLights = new List<TrafficLight>();

            foreach (string trafficLight in trafficLightsTokens)
            {
                trafficLights.Add(new TrafficLight(trafficLight));
            }

            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfChanges; i++)
            {
                trafficLights.ForEach(trafficLight => trafficLight.UpdateColor());
                Console.WriteLine(String.Join(" ", trafficLights.Select(x => x.Color)));
            }
        }
    }
}
