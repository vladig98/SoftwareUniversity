using Microsoft.Extensions.DependencyInjection;
using Pizzeria.App.Core.Contracts;
using Pizzeria.Services.Contracts;
using System;

namespace Pizzeria.App.Core
{
    internal class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            var initializeDb = serviceProvider.GetService<IDbInitializerService>();
            initializeDb.InitializeDatabase();

            var commandInterpreter = serviceProvider.GetService<ICommandInterpreter>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string result = commandInterpreter.Read(input);
                Console.WriteLine(result);
            }
        }
    }
}
