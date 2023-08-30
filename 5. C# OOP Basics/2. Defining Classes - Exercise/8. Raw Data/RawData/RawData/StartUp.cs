using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");

                string model = inputTokens[0];
                int engineSpeed = int.Parse(inputTokens[1]);
                int enginePower = int.Parse(inputTokens[2]);
                int cargoWeight = int.Parse(inputTokens[3]);
                string cargoType = inputTokens[4];
                double tire1Pressure = double.Parse(inputTokens[5]);
                int tire1Age = int.Parse(inputTokens[6]);
                double tire2Pressure = double.Parse(inputTokens[7]);
                int tire2Age = int.Parse(inputTokens[8]);
                double tire3Pressure = double.Parse(inputTokens[9]);
                int tire3Age = int.Parse(inputTokens[10]);
                double tire4Pressure = double.Parse(inputTokens[11]);
                int tire4Age = int.Parse(inputTokens[12]);

                cars.Add(new Car(model, engineSpeed, enginePower, cargoWeight, (CargoType)Enum.Parse(typeof(CargoType), cargoType), tire1Pressure,
                    tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age));
            }

            string input = Console.ReadLine();

            CargoType parsedEnum = (CargoType)Enum.Parse(typeof(CargoType), input);

            if (parsedEnum == CargoType.fragile)
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == parsedEnum && x.Tires.Any(y => y.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(x => x.Cargo.Type == parsedEnum && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
