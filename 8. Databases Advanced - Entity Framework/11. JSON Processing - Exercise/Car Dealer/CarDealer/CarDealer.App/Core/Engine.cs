using CarDealer.App.Core.Contracts;
using CarDealer.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CarDealer.App.Core
{
    public class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            var initializeService = this.serviceProvider.GetService<IDatabaseInitializerService>();
            initializeService.InitializeDatabase();

            var dataSeeder = serviceProvider.GetService<IDataSeeder>();
            dataSeeder.Seed();

            var dataExporter = serviceProvider.GetService<IDataExporter>();
            dataExporter.ExportOrderedCustomers();
            dataExporter.ExportCarsFromMakeToyota();
            dataExporter.ExportLocalSuppliers();
            dataExporter.ExportCarsWithTheirListOfParts();
            dataExporter.ExportTotalSalesByCustomer();
            dataExporter.ExportSalesWithAppliedDiscount();
        }
    }
}
