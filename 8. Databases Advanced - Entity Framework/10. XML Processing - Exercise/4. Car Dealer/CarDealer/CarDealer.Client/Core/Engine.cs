using CarDealer.Client.Core.Contracts;
using CarDealer.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CarDealer.Client.Core
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

            var dataSeeder = serviceProvider.GetService<IDatabaseDataSeeder>();
            dataSeeder.Seed();

            var dataExporter = serviceProvider.GetService<IDataExporterService>();
            dataExporter.ExportCarsWithDistance();
            dataExporter.ExportCarsFromMakeFerrari();
            dataExporter.ExportLocalSuppliers();
            dataExporter.ExportCarsWithTheirListOfParts();
            dataExporter.ExportTotalSalesByCustomer();
            dataExporter.ExportSalesWithAppliedDiscount();
        }
    }
}
