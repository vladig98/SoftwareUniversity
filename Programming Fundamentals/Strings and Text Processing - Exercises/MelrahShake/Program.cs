using System;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            int counter = 0;

            while (true)
            {
                if (input.Length < pattern.Length || pattern.Length == 0)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    return;
                }

                for (int i = 0; i <= input.Length - 1 - pattern.Length; i++)
                {
                    string partOfInput = string.Empty;
                    for (int j = i; j < i + pattern.Length; j++)
                    {
                        partOfInput += input[j];
                    }

                    if (partOfInput == pattern)
                    {
                        counter++;
                        input = input.Remove(i, pattern.Length);
                        break;
                    }
                }

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    string partOfInput = string.Empty;
                    int index = (i - pattern.Length) + 1;
                    if (index < 0)
                    {
                        break;
                    }
                    for (int j = index; j <= i; j++)
                    {
                        partOfInput += input[j];
                    }

                    if (partOfInput == pattern)
                    {
                        counter++;
                        input = input.Remove(index, pattern.Length);
                        break;
                    }
                }

                if (counter != 0 && counter % 2 == 0)
                {
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove((int)Math.Floor(pattern.Length / 2.0), 1);
                    counter = 0;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    return;
                }
            }
        }
    }
}
