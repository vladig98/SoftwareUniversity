using System;
using System.Collections.Generic;
using System.Linq;

namespace BePositive
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code to debug and fix


            //int countSequences = int.Parse(Console.ReadLine());

            //for (int i = 0; i < countSequences; i++)
            //{
            //    string[] input = Console.ReadLine().Trim().Split(' ');
            //    var numbers = new List<int>();

            //    for (int j = 0; j < input.Length; j++)
            //    {
            //        if (!input[j].Equals(string.Empty))
            //        {
            //            int num = int.Parse(input[i]);
            //            numbers.Add(num);
            //        }
            //    }

            //    bool found = false;

            //    for (int j = 0; j < numbers.Count; j++)
            //    {
            //        int currentNum = numbers[j];

            //        if (currentNum > 0)
            //        {
            //            if (found)
            //            {
            //                Console.Write(" ");
            //            }

            //            Console.Write(currentNum);

            //            found = true;
            //        }
            //        else
            //        {
            //            currentNum += numbers[j + 1];

            //            if (currentNum > 0)
            //            {
            //                if (found)
            //                {
            //                    Console.Write(" ");
            //                }

            //                Console.Write(currentNum);

            //                found = true;
            //            }
            //        }
            //    }

            //    if (!found)
            //    {
            //        Console.WriteLine("(empty)");
            //    }
            //}

            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers.ElementAt(j);

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        try
                        {
                            currentNum += numbers.ElementAt(j + 1);
                            j++;
                        }
                        catch (Exception)
                        {
                        }

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                    if (j >= numbers.Count - 1 && found)
                    {
                        Console.WriteLine();
                    }
                }

                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
            }
        }
    }
}
