using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace VehiclesExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split(" ");
            string[] truckTokens = Console.ReadLine().Split(" ");
            string[] busTokens = Console.ReadLine().Split(" ");
            int numberOfCommands = int.Parse(Console.ReadLine());

            Car Car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
            Truck Truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
            Bus Bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");

                switch (inputTokens[0])
                {
                    case "Drive":
                        switch (inputTokens[1])
                        {
                            case "Car":
                                Car.Drive(double.Parse(inputTokens[2]));
                                break;
                            case "Truck":
                                Truck.Drive(double.Parse(inputTokens[2]));
                                break;
                            case "Bus":
                                Bus.Drive(double.Parse(inputTokens[2]));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Refuel":
                        switch (inputTokens[1])
                        {
                            case "Car":
                                Car.Refuel(double.Parse(inputTokens[2]));
                                break;
                            case "Truck":
                                Truck.Refuel(double.Parse(inputTokens[2]));
                                break;
                            case "Bus":
                                Bus.Refuel(double.Parse(inputTokens[2]));
                                break;
                            default:
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        Bus.DriveEmpty(double.Parse(inputTokens[2]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(Car);
            Console.WriteLine(Truck);
            Console.WriteLine(Bus);
        }
    }
}
