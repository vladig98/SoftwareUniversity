using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
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
                Car car = new Car(inputTokens[0], double.Parse(inputTokens[1]), double.Parse(inputTokens[2]));
                cars.Add(car);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputTokens = input.Split(" ");

                Car car = cars.Where(x => x.Model == inputTokens[1]).FirstOrDefault();

                if (car != null)
                {
                    car.Drive(double.Parse(inputTokens[2]));
                }

                input = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
