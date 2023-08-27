using System;

namespace EventImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();
            Dispatcher dispatcher = new Dispatcher(handler);

            dispatcher.NameChange += new NameChangeEventHandler(handler.OnDispatcherNameChange);

            string input = Console.ReadLine();

            while (input != "End")
            {
                dispatcher.OnNameChange(new NameChangeEventArgs(input));

                input = Console.ReadLine();
            }
        }
    }
}
