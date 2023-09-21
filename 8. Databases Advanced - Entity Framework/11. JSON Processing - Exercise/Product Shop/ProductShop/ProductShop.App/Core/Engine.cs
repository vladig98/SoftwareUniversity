using Microsoft.Extensions.DependencyInjection;
using ProductShop.App.Core.Contracts;
using ProductShop.Services.Contracts;
using System;

namespace ProductShop.App.Core
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

            var dataSeeder = serviceProvider.GetService<IDataSeeder>();
            dataSeeder.Seed();

            var dataExporter = serviceProvider.GetService<IDataExporter>();
            dataExporter.ExportProductsInRange();
            dataExporter.ExportSuccessfullySoldProducts();
            dataExporter.ExportCategoriesByProductsCount();
            dataExporter.ExportUsersAndProducts();
        }
    }
}
