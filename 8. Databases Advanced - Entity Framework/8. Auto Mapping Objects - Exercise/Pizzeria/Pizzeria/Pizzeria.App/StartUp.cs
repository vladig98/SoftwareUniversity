using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pizzeria.App.Core;
using Pizzeria.App.Core.Contracts;
using Pizzeria.App.Core.Controllers;
using Pizzeria.Data;
using Pizzeria.Services;
using Pizzeria.Services.Contracts;
using System;

namespace Pizzeria.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var servive = ConfigureService();
            IEngine engine = new Engine(servive);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<PizzeriaContext>(opts => opts.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddAutoMapper(conf => conf.AddProfile<PizzeriaProfile>());

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();
            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();
            serviceCollection.AddTransient<IManagerController, ManagerController>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
