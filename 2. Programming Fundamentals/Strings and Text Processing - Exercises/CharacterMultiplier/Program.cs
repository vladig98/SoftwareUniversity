using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ").ToArray();

            long sum = 0;

            for (int i = 0; i < Math.Min(inputs[0].Length, inputs[1].Length); i++)
            {
                sum += inputs[0][i] * inputs[1][i];
            }

            sum += inputs[0].Skip(Math.Min(inputs[0].Length, inputs[1].Length)).ToArray().Sum(x => (int)x);
            sum += inputs[1].Skip(Math.Min(inputs[0].Length, inputs[1].Length)).ToArray().Sum(x => (int)x);

            Console.WriteLine(sum);
        }
    }
}
