using CarDealer.Data;
using CarDealer.Services.Contracts;
using CarDealer.Services.Dtos;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarDealer.Services
{
    public class DataExporter : IDataExporter
    {
        private readonly CarDealerDbContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\Exports\";

        public DataExporter(CarDealerDbContext context)
        {
            this.context = context;
        }

        public void ExportCarsFromMakeToyota()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "toyota-cars.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var cars = context.Cars.ToList().Where(x => x.Make == "Toyota")
                .OrderBy(x => x.Model).ThenByDescending(x => x.TraveledDistance).ToList();

            List<CarExportDto> carsDtos = new List<CarExportDto>();

            foreach (var car in cars)
            {
                carsDtos.Add(new CarExportDto
                {
                    Id = car.Id,
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TraveledDistance
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, carsDtos);
            }
        }

        public void ExportCarsWithTheirListOfParts()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "cars-and-parts.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var cars = context.Cars.Include(x => x.Parts).ThenInclude(x => x.Part).ToList();

            List<CarsAndPartsDto> carsDto = new List< CarsAndPartsDto>();

            foreach (var car in cars)
            {
                CPCarDto carDto = new CPCarDto
                {
                    Make = car.Make,
                    Model = car.Model,
                    TravelledDistance = car.TraveledDistance
                };

                List<PartExportDto> partDtos = new List<PartExportDto>();

                foreach (var part in car.Parts)
                {
                    partDtos.Add(new PartExportDto
                    {
                        Name = part.Part.Name,
                        Price = part.Part.Price,
                    });
                }

                carsDto.Add(new CarsAndPartsDto
                {
                    car = carDto,
                    parts = partDtos
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, carsDto);
            }
        }

        public void ExportLocalSuppliers()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "local-suppliers.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var suppliers = context.Suppliers.Include(x => x.Parts).ToList().Where(x => x.IsImporter == false).ToList();

            List<SupplierExportDto> supplierDtos = new List<SupplierExportDto>();

            foreach (var supplier in suppliers)
            {
                supplierDtos.Add(new SupplierExportDto
                {
                    Id= supplier.Id,
                    Name = supplier.Name,
                    PartsCount = supplier.Parts.Count
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, supplierDtos);
            }
        }

        public void ExportOrderedCustomers()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "ordered-customers.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var customers = context.Customers.ToList().OrderBy(x => x.BirthDate).ThenBy(x => x.IsYoungDriver).ToList();

            List<CustomerExportDto> customerDtos = new List<CustomerExportDto>();

            foreach (var customer in customers)
            {
                customerDtos.Add(new CustomerExportDto
                {
                    BirthDate = customer.BirthDate,
                    Id = customer.Id,
                    Name = customer.Name,
                    IsYoungDriver = customer.IsYoungDriver,
                    Sales = new List<Models.Sale>()
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, customerDtos);
            }
        }

        public void ExportSalesWithAppliedDiscount()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "sales-discounts.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var sales = context.Sales.Include(x => x.Car).ThenInclude(x => x.Parts).ThenInclude(x => x.Part).Include(x => x.Customer).ToList();

            List<SalesDiscountsDto> salesDtos = new List<SalesDiscountsDto>();

            foreach (var sale in sales)
            {
                CPCarDto carDto = new CPCarDto
                {
                    Make = sale.Car.Make,
                    Model = sale.Car.Model,
                    TravelledDistance = sale.Car.TraveledDistance
                };

                salesDtos.Add(new SalesDiscountsDto
                {
                    car = carDto,
                    customerName = sale.Customer.Name,
                    Discount = sale.Discount / 100.0m,
                    price = sale.Car.Parts.Sum(x => x.Part.Price),
                    priceWithDiscount = sale.Car.Parts.Sum(x => x.Part.Price) - (sale.Car.Parts.Sum(x => x.Part.Price) * sale.Discount / 100.0m)
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, salesDtos);
            }
        }

        public void ExportTotalSalesByCustomer()
        {
            StreamWriter filePath = File.CreateText(pathToResources + "customers-total-sales.json");

            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;

            var customers = context.Customers.Include(x => x.Sales).ThenInclude(x => x.Car).ThenInclude(x => x.Parts)
                .ThenInclude(x => x.Part).ToList().Where(x => x.Sales.Count > 0)
                .OrderByDescending(x => x.Sales.Sum(y => y.Car.Parts.Sum(z => z.Part.Price))).ThenByDescending(x => x.Sales.Count).ToList();

            List<CustomersTotalSalesDto> customerDtos = new List<CustomersTotalSalesDto>();

            foreach (var customer in customers)
            {
                customerDtos.Add(new CustomersTotalSalesDto
                {
                    fullName = customer.Name,
                    boughtCars = customer.Sales.Count,
                    spentMoney = customer.Sales.Sum(x => x.Car.Parts.Sum(y => y.Part.Price))
                });
            }

            using (filePath)
            {
                serializer.Serialize(filePath, customerDtos);
            }
        }
    }
}
