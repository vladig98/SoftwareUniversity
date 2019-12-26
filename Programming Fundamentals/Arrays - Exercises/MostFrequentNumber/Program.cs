using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] original = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                original[i] = numbers[i];
            }

            numbers = numbers.OrderBy(x => x).ToArray();

            int[] arr = new int[0];

            int maxLength = 0;
            int tempLength = 1;
            int number = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        number = numbers[i];
                        arr = new int[1] { numbers[i] };
                    }
                    else if (tempLength == maxLength)
                    {
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
                    tempLength = 1;
                    break;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    tempLength++;
                }
                else
                {
                    if (tempLength > maxLength)
                    {
                        maxLength = tempLength;
                        number = numbers[i];
                        arr = new int[1] { numbers[i] };
                    }
                    else if (tempLength == maxLength)
                    {
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
                    tempLength = 1;
                }
            }

            if (arr.Length > 1)
            {
                int pos = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    int tempPos = Array.IndexOf(original, arr[i]);

                    if (tempPos < pos)
                    {
                        pos = tempPos;
                    }
                }
                number = original[pos];
            }

            Console.WriteLine(number);
        }
    }
}
