using System;

namespace TeamBuilder.App.Core
{
    public class Engine
    {
        private CommandDispatcher dispatcher;

        public Engine(CommandDispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string output = dispatcher.Dispatch(input);

                    Console.WriteLine(output);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetBaseException().Message);
                }
            }
        }
    }
}
