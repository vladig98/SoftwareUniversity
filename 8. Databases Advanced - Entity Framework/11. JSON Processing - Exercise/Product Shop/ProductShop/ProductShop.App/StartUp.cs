using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ProductShop.Data;
using System;
using ProductShop.App.Core.Contracts;
using ProductShop.App.Core;
using Microsoft.EntityFrameworkCore;
using ProductShop.Services.Contracts;
using ProductShop.Services;

namespace ProductShop.App
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            IEngine engine = new Engine(serviceProvider);
            engine.Start();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<ProductShopContext>(options =>
                options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<ProductShopProfile>());

            //Add services to the serviceCollection
            serviceCollection.AddTransient<IDatabaseInitializerService, DatabaseInitializerService>();
            serviceCollection.AddTransient<IDataSeeder, DataSeeder>();
            serviceCollection.AddTransient<IDataExporter, DataExporter>();

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
