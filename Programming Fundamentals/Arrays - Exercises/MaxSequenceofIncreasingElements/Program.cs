using System;
using System.Linq;

namespace MaxSequenceofIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int maxLength = 0;
            int tempLegth = 0;

            int[] arr = new int[0];
            int[] seq = new int[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    if (tempLegth > maxLength)
                    {
                        maxLength = tempLegth;
                        seq = new int[arr.Length];
                        for (int j = 0; j < arr.Length; j++)
                        {
                            seq[j] = arr[j];
                        }
                        arr = new int[0];
                    }
                    tempLegth = 0;
                    break;
                }
                if (numbers[i] < numbers[i + 1])
                {
                    tempLegth++;
                    int[] temp = new int[arr.Length];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        temp[j] = arr[j];
                    }
                    arr = new int[arr.Length + 1];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        arr[j] = temp[j];
                    }
                    arr[arr.Length - 1] = numbers[i];
                }
                else
                {
                    if (tempLegth > maxLength)
                    {
                        maxLength = tempLegth;
                        seq = new int[arr.Length];
                        for (int j = 0; j < arr.Length; j++)
                        {
                            seq[j] = arr[j];
                        }
                        arr = new int[0];
                    }
                    tempLegth = 0;
                }
            }

            string subString = string.Join(" ", seq);
            string numbersString = string.Join(" ", numbers);

            string result = string.Empty;

            try
            {
                result = numbersString.Substring(numbersString.IndexOf(subString), subString.Length + 3);
            }
            catch (Exception)
            {
                result = numbersString.Substring(numbersString.IndexOf(subString), subString.Length + 2);
            }

            Console.WriteLine(result);
        }
    }
}
