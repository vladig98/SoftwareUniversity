using CarDealer.Client.Core;
using CarDealer.Client.Core.Contracts;
using CarDealer.Data;
using CarDealer.Services;
using CarDealer.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CarDealer.Client
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IServiceProvider serviceProvider = GetServiceProvider();
            IEngine engine = new Engine(serviceProvider);
            engine.Run();
        }

        private static IServiceProvider GetServiceProvider()
        {
            var serviceCollection = new ServiceCollection();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..")))
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddDbContext<CarDealerDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //Add services to the serviceCollection
            serviceCollection.AddTransient<IDatabaseInitializerService, DatabaseInitializerService>();
            serviceCollection.AddTransient<IDatabaseDataSeeder, DatabaseDataSeeder>();
            serviceCollection.AddTransient<IDataExporterService, DataExporterService>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
