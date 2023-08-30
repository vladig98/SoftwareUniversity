using System;

namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tokens1 = Console.ReadLine().Split(" ");
            Tuple.Tuple<string, string> tuple = new Tuple.Tuple<string, string>($"{tokens1[0]} {tokens1[1]}", tokens1[2]);

            string[] tokens2 = Console.ReadLine().Split(" ");
            Tuple.Tuple<string, int>  tuple2 = new Tuple.Tuple<string, int>(tokens2[0], int.Parse(tokens2[1]));

            string[] tokens3 = Console.ReadLine().Split(" ");
            Tuple.Tuple<int, double> tuple3 = new Tuple.Tuple<int, double>(int.Parse(tokens3[0]), double.Parse(tokens3[1]));

            Console.WriteLine(tuple);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
