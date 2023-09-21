using Microsoft.Extensions.DependencyInjection;
using ProductShop.Client.Core.Contracts;
using ProductShop.Services.Contracts;
using System;

namespace ProductShop.Client.Core
{
    public class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Start()
        {
            var initializeService = this.serviceProvider.GetService<IDatabaseInitializerService>();
            initializeService.InitializeDatabase();

            var dataSeeder = serviceProvider.GetService<IDatabaseDataSeeder>();
            dataSeeder.Seed();

            var dataExporter = serviceProvider.GetService<IDataExporterService>();
            dataExporter.ExportProductsInRange();
            dataExporter.ExportSoldProducts();
            dataExporter.ExportCategoriesByProductsCount();
            dataExporter.ExportUsersAndProducts();

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter command...");
            //        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //        string result = commandInterpreter.Read(input);
            //        Console.WriteLine(result);
            //    }
            //    catch (Exception exception) when (exception is SqlException || exception is ArgumentException ||
            //                                      exception is InvalidOperationException)
            //    {
            //        Console.WriteLine(exception.Message);
            //    }
            //}
        }
    }
}
