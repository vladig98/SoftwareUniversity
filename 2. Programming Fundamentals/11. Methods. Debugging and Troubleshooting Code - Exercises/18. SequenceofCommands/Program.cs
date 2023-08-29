using System;
using System.Linq;

namespace SequenceofCommands
{
    class Program
    {
        //part of the code to debug

        //private const char ArgumentsDelimiter = ' ';

        private const char ArgumentsDelimiter = ' ';
        static void Main(string[] args)
        {
            //Code to debug and fix

            //    int sizeOfArray = int.Parse(Console.ReadLine());

            //    long[] array = Console.ReadLine()
            //        .Split(ArgumentsDelimiter)
            //        .Select(long.Parse)
            //        .ToArray();

            //    string command = Console.ReadLine();

            //    while (!command.Equals("over"))
            //    {
            //        string line = Console.ReadLine().Trim();
            //        int[] args = new int[2];

            //        if (command.Equals("add") ||
            //            command.Equals("substract") ||
            //            command.Equals("multiply"))
            //        {
            //            string[] stringParams = line.Split(ArgumentsDelimiter);
            //            args[0] = int.Parse(stringParams[0]);
            //            args[1] = int.Parse(stringParams[1]);

            //            PerformAction(array, command, args);
            //        }

            //        PerformAction(array, command, args);

            //        PrintArray(array);
            //        Console.WriteLine('\n');

            //        command = Console.ReadLine();
            //    }
            //}

            //static void PerformAction(long[] arr, string action, int[] args)
            //{
            //    long[] array = arr.Clone() as long[];
            //    int pos = args[0];
            //    int value = args[1];

            //    switch (action)
            //    {
            //        case "multiply":
            //            array[pos] *= value;
            //            break;
            //        case "add":
            //            array[pos] += value;
            //            break;
            //        case "subtract":
            //            array[pos] -= value;
            //            break;
            //        case "lshift":
            //            ArrayShiftLeft(array);
            //            break;
            //        case "rshift":
            //            ArrayShiftRight(array);
            //            break;
            //    }
            //}

            //private static void ArrayShiftRight(long[] array)
            //{
            //    for (int i = array.Length - 1; i >= 1; i--)
            //    {
            //        array[i] = array[i - 1];
            //    }
            //}

            //private static void ArrayShiftLeft(long[] array)
            //{
            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        array[i] = array[i + 1];
            //    }
            //}

            //private static void PrintArray(long[] array)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.WriteLine(array[i] + " ");
            //    }
            //}

            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                //string line = Console.ReadLine().Trim();
                int[] arguments = new int[2];

                if (command.Split(ArgumentsDelimiter)[0].Equals("add") ||
                    command.Split(ArgumentsDelimiter)[0].Equals("subtract") ||
                    command.Split(ArgumentsDelimiter)[0].Equals("multiply"))
                {
                    string[] stringParams = command.Split(ArgumentsDelimiter);
                    arguments[0] = int.Parse(stringParams[1]);
                    arguments[1] = int.Parse(stringParams[2]);

                    //PerformAction(array, command, arguments);
                }

                PerformAction(array, command.Split(ArgumentsDelimiter)[0], arguments);

                PrintArray(array);
                //Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos - 1] *= value;
                    break;
                case "add":
                    array[pos - 1] += value;
                    break;
                case "subtract":
                    array[pos - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
                default:
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long last = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = last;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long first = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = first;
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
