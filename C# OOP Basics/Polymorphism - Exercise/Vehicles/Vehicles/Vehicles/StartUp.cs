using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carTokens = Console.ReadLine().Split(" ");
            string[] truckTokens = Console.ReadLine().Split(" ");
            int numberOfCommands = int.Parse(Console.ReadLine());

            IVehicle Car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
            IVehicle Truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

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
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(Car);
            Console.WriteLine(Truck);
        }
    }
}
