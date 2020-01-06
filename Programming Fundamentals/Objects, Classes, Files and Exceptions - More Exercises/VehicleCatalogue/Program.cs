using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Vehicle> vehicles = new List<Vehicle>();

            while (command != "End")
            {
                string[] tokens = command.Split(" ").ToArray();

                Vehicle vehicle = new Vehicle();

                vehicle.Type = tokens[0].ToLower();
                vehicle.Model = tokens[1];
                vehicle.Color = tokens[2];
                vehicle.HorsePower = int.Parse(tokens[3]);

                vehicles.Add(vehicle);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "Close the Catalogue")
            {
                Vehicle vehicle = vehicles.FirstOrDefault(x => x.Model == command);

                Console.WriteLine($"Type: {SentenseCase(vehicle.Type)}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.HorsePower}");

                command = Console.ReadLine();
            }

            try
            {
                Console.WriteLine($"Cars have average horsepower of: {vehicles.Where(x => x.Type == "car").Select(x => x.HorsePower).Average():F2}.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            try
            {
                Console.WriteLine($"Trucks have average horsepower of: {vehicles.Where(x => x.Type == "truck").Select(x => x.HorsePower).Average():F2}.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }

        private static object SentenseCase(string type)
        {
            return type[0].ToString().ToUpper() + string.Join("", type.Skip(1));
        }

        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
    }
}
