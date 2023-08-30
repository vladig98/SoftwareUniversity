using System;

namespace GenericBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericBox<int> box = new GenericBox<int>(123123);
            GenericBox<string> box2 = new GenericBox<string>("life in a box");
            Console.WriteLine(box);
            Console.WriteLine(box2);
        }
    }
}
