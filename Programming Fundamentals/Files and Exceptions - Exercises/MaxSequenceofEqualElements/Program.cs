using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MaxSequenceofEqualElements
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

                int maxLength = 0;
                int tempLenght = 0;
                int number = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i == numbers.Length - 1)
                    {
                        if (tempLenght > maxLength)
                        {
                            maxLength = tempLenght;
                            number = numbers[i];
                        }
                        tempLenght = 0;
                        break;
                    }
                    if (numbers[i] == numbers[i + 1])
                    {
                        tempLenght++;
                    }
                    else
                    {
                        if (tempLenght > maxLength)
                        {
                            maxLength = tempLenght;
                            number = numbers[i];
                        }
                        tempLenght = 0;
                    }
                }

                if (maxLength == 0)
                {
                    maxLength = tempLenght;
                    number = numbers[0];
                }

                string result = string.Empty;
                for (int i = 0; i <= maxLength; i++)
                {
                    result += number.ToString() + " ";
                }

                results.Add(result);
            }

            File.WriteAllLines(path + "output.txt", results);
        }
    }
}
