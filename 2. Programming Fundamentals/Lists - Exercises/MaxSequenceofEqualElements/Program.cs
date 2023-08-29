using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList<int>();

            int longest = 0;
            int current = 0;
            int start = -1;
            int end = -1;
            int startTemp = -1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers.ElementAt(i) == numbers.ElementAt(i + 1))
                {
                    current++;
                    startTemp = startTemp == -1 ? i : startTemp;
                }
                else
                {
                    if (current > longest)
                    {
                        longest = current;
                        start = startTemp;
                        end = i;
                    }
                    current = 0;
                    startTemp = -1;
                }

                if (current > longest)
                {
                    longest = current;
                    start = startTemp;
                    end = i;
                }
            }

            start = start == -1 ? startTemp : start;
            end = end == -1 ? numbers.Count - 1 : end;

            if (startTemp == -1 && start == -1)
            {
                Console.Write(numbers.ElementAt(0));
                return;
            }

            for (int i = start; i <= end + 1; i++)
            {
                Console.Write(numbers.ElementAt(i) + " ");
            }
        }
    }
}
