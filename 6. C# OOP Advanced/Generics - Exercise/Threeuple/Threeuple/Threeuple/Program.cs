using System;

namespace Threeuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] tokens1 = Console.ReadLine().Split(" ");
            Threeuple.Threeuple<string, string, string> threeuple = new 
                Threeuple.Threeuple<string, string, string>($"{tokens1[0]} {tokens1[1]}", tokens1[2], tokens1[3]);

            string[] tokens2 = Console.ReadLine().Split(" ");
            Threeuple.Threeuple<string, int, bool> threeuple2 = new 
                Threeuple.Threeuple<string, int, bool>(tokens2[0], int.Parse(tokens2[1]), tokens2[2] == "drunk" ? true : false);

            string[] tokens3 = Console.ReadLine().Split(" ");
            Threeuple.Threeuple<string, double, string> threeuple3 = new 
                Threeuple.Threeuple<string, double, string>(tokens3[0], double.Parse(tokens3[1]), tokens3[2]);

            Console.WriteLine(threeuple);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
    }
}
