using System;
using System.Linq;

namespace IteratorTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ListIterator list = null;

            while (input != "END")
            {
                string[] tokens = input.Split(' ');

                try
                {
                    switch (tokens[0])
                    {
                        case "Create":
                            list = new ListIterator(tokens.Skip(1).ToList());
                            break;
                        case "Move":
                            Console.WriteLine(list.Move());
                            break;
                        case "Print":
                            list.Print();
                            break;
                        case "HasNext":
                            Console.WriteLine(list.HasNext());
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
