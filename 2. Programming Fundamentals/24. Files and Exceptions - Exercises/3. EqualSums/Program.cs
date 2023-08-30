using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";

            string[] input = File.ReadAllLines(path + "input.txt");
            List<string> results = new List<string>();

            for (int k = 0; k < input.Length; k++)
            {
                int[] numbers = input[k].Split(" ").Select(int.Parse).ToArray();

                bool isFound = false;
                int index = -1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    int rightSum = 0;
                    int leftSum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += numbers[j];
                    }
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        rightSum += numbers[j];
                    }

                    if (leftSum == rightSum)
                    {
                        index = i;
                        isFound = true;
                    }
                }

                if (!isFound)
                {
                    results.Add("no");
                }
                else
                {
                    results.Add(index.ToString());
                }
            }

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
