using System;

namespace GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    Console.WriteLine(GetMax(string1, string2));
                    break;
                case "int":
                    int int1 = int.Parse(Console.ReadLine());
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(int1, int2));
                    break;
                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(char1, char2));
                    break;
                default:
                    break;
            }
        }

        static string GetMax(string value1, string value2)
        {
            if (value1.CompareTo(value2) >= 0)
            {
                return value1;
            }
            return value2;
        }

        static int GetMax(int value1, int value2)
        {
            return Math.Max(value1, value2);
        }

        static char GetMax(char value1, char value2)
        {
            return (char)Math.Max(value1, value2);
        }
    }
}
