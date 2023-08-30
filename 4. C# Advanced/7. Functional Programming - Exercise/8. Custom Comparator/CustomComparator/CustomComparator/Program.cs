using System;
using System.Collections;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            IComparer evenNumbersFirst = new EvenNumbersFirst();

            Action<int[]> sort = numbers => Array.Sort(numbers, null, 0, numbers.Length, evenNumbersFirst);
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

            sort(numbers);
            print(numbers);
        }

        private class EvenNumbersFirst : IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                if (int.Parse(x.ToString()) % 2 == 0 && int.Parse(y.ToString()) % 2 == 0)
                {
                    if (int.Parse(x.ToString()) < int.Parse(y.ToString()))
                    {
                        return -1;
                    }

                    if (int.Parse(x.ToString()) == int.Parse(y.ToString()))
                    {
                        return 0;
                    }

                    if (int.Parse(x.ToString()) > int.Parse(y.ToString()))
                    {
                        return 1;
                    }
                }

                if (int.Parse(x.ToString()) % 2 == 0 && int.Parse(y.ToString()) % 2 != 0)
                {
                    return -1;
                }

                if (int.Parse(x.ToString()) % 2 != 0 && int.Parse(y.ToString()) % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    if (int.Parse(x.ToString()) < int.Parse(y.ToString()))
                    {
                        return -1;
                    }

                    if (int.Parse(x.ToString()) == int.Parse(y.ToString()))
                    {
                        return 0;
                    }

                    if (int.Parse(x.ToString()) > int.Parse(y.ToString()))
                    {
                        return 1;
                    }
                }

                return 0;
            }
        }
    }
}
