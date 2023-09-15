using AutoMapper;
using BusTicketsSystem.Client.Core;
using BusTicketsSystem.Client.Core.Contracts;
using BusTicketsSystem.Data;
using BusTicketsSystem.Services;
using BusTicketsSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace BusTicketsSystem.Client
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var service = ConfigureServices();
            Engine engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..")))
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddDbContext<BusTicketsSystemContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<BusTicketsSystemProfile>());

            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();

            //Add services to the serviceCollection
            serviceCollection.AddTransient<IDatabaseInitializerService, DatabaseInitializerService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
