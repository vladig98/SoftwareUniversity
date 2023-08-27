using System;

namespace DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Handler handler = new Handler();
            PrimitiveCalculator calculator = new PrimitiveCalculator(handler);

            calculator.StrategyChange += new CalculateEventHandler(handler.OnCalculatorCalculate);

            while (command != "End")
            {
                string[] inputTokens = command.Split(' ');

                if (inputTokens[0] == "mode")
                {
                    calculator.changeStrategy(inputTokens[1][0]);
                }
                else
                {
                    double result = calculator.performCalculation(int.Parse(inputTokens[0]), int.Parse(inputTokens[1]));

                    Console.WriteLine(result);
                }

                command = Console.ReadLine();
            }
        }
    }
}
