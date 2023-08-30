using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());

            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            for (int i = 0; i < numberOfNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences.Add(number, 1);
                }
            }

            Console.WriteLine(occurrences.FirstOrDefault(x => x.Value % 2 == 0).Key);
        }
    }
}
