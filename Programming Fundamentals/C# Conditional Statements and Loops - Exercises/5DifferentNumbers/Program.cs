using System;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int diff = number2 - number1 + 1;
            if (diff < 5)
            {
                Console.WriteLine("No");
                return;
            }

            int n1 = number1;
            int n2 = number1 + 1;
            int n3 = number1 + 2;
            int n4 = number1 + 3;
            int n5 = number1 + 4;

            while (n5 <= number2 || n4 <= number2 - 1 || n3 <= number2 - 2 || n2 <= number2 - 3 || n1 <= number2 - 4)
            {
                Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                n5++;
                if (n5 > number2)
                {
                    n4++;
                    n5 = n4 + 1;
                    if (n5 > number2)
                    {
                        n5 = number2;
                    }
                    if (n4 > number2 - 1)
                    {
                        n3++;
                        n4 = n3 + 1;
                        n5 = n4 + 1;
                        if (n4 > number2 - 1)
                        {
                            n4 = number2 - 1;
                        }
                        if (n5 > number2)
                        {
                            n5 = number2;
                        }
                        if (n3 > number2 - 2)
                        {
                            n2++;
                            n3 = n2 + 1;
                            n4 = n3 + 1;
                            n5 = n4 + 1;
                            if (n3 > number2 - 2)
                            {
                                n3 = number2 - 2;
                            }
                            if (n4 > number2 - 1)
                            {
                                n4 = number2 - 1;
                            }
                            if (n5 > number2)
                            {
                                n5 = number2;
                            }
                            if (n2 > number2 - 3)
                            {
                                n1++;
                                n2 = n1 + 1;
                                n3 = n2 + 1;
                                n4 = n3 + 1;
                                n5 = n4 + 1;
                                if (n2 > number2 - 3)
                                {
                                    n2 = number2 - 3;
                                }
                                if (n3 > number2 - 2)
                                {
                                    n3 = number2 - 2;
                                }
                                if (n4 > number2 - 1)
                                {
                                    n4 = number2 - 1;
                                }
                                if (n5 > number2)
                                {
                                    n5 = number2;
                                }
                                if (n1 > number2 - 4)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
