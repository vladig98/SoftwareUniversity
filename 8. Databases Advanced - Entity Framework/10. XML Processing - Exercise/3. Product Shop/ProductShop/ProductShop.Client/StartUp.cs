using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductShop.Client.Core;
using ProductShop.Client.Core.Contracts;
using ProductShop.Services.Contracts;
using ProductShop.Services;
using System;
using System.IO;
using ProductShop.Data;

namespace ProductShop.Client
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            IEngine engine = new Engine(serviceProvider);
            engine.Start();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..")))
                .AddJsonFile("appsettings.json")
                .Build();

            serviceCollection.AddDbContext<ProductShopDbContext>(options =>
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
