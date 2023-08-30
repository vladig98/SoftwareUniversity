using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputTokens[0];
                int power = int.Parse(inputTokens[1]);
                int? displacement = null;
                string efficiency = null;

                if (inputTokens.Length > 2)
                {
                    if (Regex.IsMatch(inputTokens[2], @"\d+"))
                    {
                        displacement = int.Parse(inputTokens[2]);
                    }
                    else
                    {
                        efficiency = inputTokens[2];
                    }
                }

                if (inputTokens.Length > 3)
                {
                    efficiency = inputTokens[3];
                }

                if (displacement == null && efficiency == null)
                {
                    engines.Add(new Engine(model, power));
                    continue;
                }

                if (displacement == null)
                {
                    engines.Add(new Engine(model, power, efficiency));
                    continue;
                }

                if (efficiency == null)
                {
                    engines.Add(new Engine(model, power, (int)displacement));
                    continue;
                }

                engines.Add(new Engine(model, power, (int)displacement, efficiency));
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputTokens[0];
                Engine engine = engines.Where(x => x.Model == inputTokens[1]).FirstOrDefault();
                int? weigth = null;
                string color = null;

                if (inputTokens.Length > 2)
                {
                    if (Regex.IsMatch(inputTokens[2], @"\d+"))
                    {
                        weigth = int.Parse(inputTokens[2]);
                    }
                    else
                    {
                        color = inputTokens[2];
                    }
                }

                if (inputTokens.Length > 3)
                {
                    color = inputTokens[3];
                }

                if (weigth == null && color == null)
                {
                    cars.Add(new Car(model, engine));
                    continue;
                }

                if (weigth == null)
                {
                    cars.Add(new Car(model, engine, color));
                    continue;
                }

                if (color == null)
                {
                    cars.Add(new Car(model, engine, (int)weigth));
                    continue;
                }

                cars.Add(new Car(model, engine, (int)weigth, color));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
