using CarDealer.Data;
using CarDealer.Services.Contracts;
using CarDealer.Services.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CarDealer.Services
{
    public class DataExporterService : IDataExporterService
    {
        private readonly CarDealerDbContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\Exports\";

        public DataExporterService(CarDealerDbContext context)
        {
            this.context = context;
        }

        public void ExportCarsFromMakeFerrari()
        {
            string fileName = pathToResources + "ferrari-cars.xml";

            var serializer = new XmlSerializer(typeof(List<CarExportDto>), new XmlRootAttribute("cars"));
            var writer = new StreamWriter(fileName);

            var cars = context.Cars.ToList().Where(x => x.Make == "Ferrari").OrderBy(x => x.Model)
                .ThenByDescending(x => x.TraveledDistance).ToList();

            List<CarExportDto> carsDtos = new List<CarExportDto>();

            foreach (var car in cars)
            {
                carsDtos.Add(new CarExportDto
                {
                    Id = car.Id,
                    Model = car.Model,
                    TraveledDistance = car.TraveledDistance
                });
            }

            serializer.Serialize(writer, carsDtos);
        }

        public void ExportCarsWithDistance()
        {
            string fileName = pathToResources + "cars.xml";

            var serializer = new XmlSerializer(typeof(List<CarDto>), new XmlRootAttribute("cars"));
            var writer = new StreamWriter(fileName);

            var cars = context.Cars.ToList().Where(x => x.TraveledDistance > 2000000).OrderBy(x => x.Make).ThenBy(x => x.Model).ToList();

            List<CarDto> carsDtos = new List<CarDto>();

            foreach (var car in cars)
            {
                carsDtos.Add(new CarDto
                {
                    Make = car.Make,
                    Model = car.Model,
                    TraveledDistance = car.TraveledDistance
                });
            }

            serializer.Serialize(writer, carsDtos);
        }

        public void ExportCarsWithTheirListOfParts()
        {
            string fileName = pathToResources + "cars-and-parts.xml";

            var serializer = new XmlSerializer(typeof(List<CPCarDto>), new XmlRootAttribute("cars"));
            var writer = new StreamWriter(fileName);

            var cars = context.Cars.Include(x => x.Parts).ThenInclude(x => x.Part).ToList();

            List<CPCarDto> carsDtos = new List<CPCarDto>();

            foreach (var car in cars)
            {
                List<CPPartDto> parts = new List<CPPartDto>();

                foreach (var part in car.Parts)
                {
                    parts.Add(new CPPartDto
                    {
                        Name = part.Part.Name,
                        Price = part.Part.Price,
                    });
                }

                carsDtos.Add(new CPCarDto
                {
                    Make = car.Make,
                    Model = car.Model,
                    TraveledDistance = car.TraveledDistance,
                    Parts = parts.ToHashSet()
                });
            }

            serializer.Serialize(writer, carsDtos);
        }

        public void ExportLocalSuppliers()
        {
            string fileName = pathToResources + "local-suppliers.xml";

            var serializer = new XmlSerializer(typeof(List<SupplierExportDto>), new XmlRootAttribute("suppliers"));
            var writer = new StreamWriter(fileName);

            var suppliers = context.Suppliers.Include(x => x.Parts).ToList().Where(x => x.IsImporter == false).ToList();

            List<SupplierExportDto> suppliersDtos = new List<SupplierExportDto>();

            foreach (var supplier in suppliers)
            {
                suppliersDtos.Add(new SupplierExportDto
                {
                    Id = supplier.Id,
                    Name = supplier.Name,
                    PartsCount = supplier.Parts.Count
                });
            }

            serializer.Serialize(writer, suppliersDtos);
        }

        public void ExportSalesWithAppliedDiscount()
        {
            string fileName = pathToResources + "sales-discounts.xml";

            var serializer = new XmlSerializer(typeof(List<SaleDto>), new XmlRootAttribute("sales"));
            var writer = new StreamWriter(fileName);

            var sales = context.Sales.Include(x => x.Car).ThenInclude(x => x.Parts).ThenInclude(x => x.Part).Include(x => x.Customer).ToList();

            List<SaleDto> saleDtos = new List<SaleDto>();

            foreach (var sale in sales)
            {
                var car = sale.Car;

                var carDto = new CarSaleDto
                {
                    Make = car.Make,
                    Model = car.Model,
                    TraveledDistance = car.TraveledDistance
                };

                saleDtos.Add(new SaleDto
                {
                    CustomerName = sale.Customer.Name,
                    Discount = sale.Discount / 100.0m,
                    Price = sale.Car.Parts.Sum(x => x.Part.Price),
                    PriceWithDiscount = sale.Car.Parts.Sum(x => x.Part.Price) - (sale.Car.Parts.Sum(x => x.Part.Price) * sale.Discount / 100),
                    Car = carDto
                });
            }

            serializer.Serialize(writer, saleDtos);
        }

        public void ExportTotalSalesByCustomer()
        {
            string fileName = pathToResources + "customers-total-sales.xml";

            var serializer = new XmlSerializer(typeof(List<CustomerExportDto>), new XmlRootAttribute("customers"));
            var writer = new StreamWriter(fileName);

            var customers = context.Customers.Include(x => x.Sales).ThenInclude(x => x.Car).ThenInclude(x => x.Parts).ThenInclude(x => x.Part)
                .ToList().Where(x => x.Sales.Count > 0)
                .OrderByDescending(x => x.Sales.Sum(y => y.Car.Parts.Sum(z => z.Part.Price)))
                .ThenByDescending(x => x.Sales.Count).ToList();

            List<CustomerExportDto> customersDtos = new List<CustomerExportDto>();

            foreach (var customer in customers)
            {
                customersDtos.Add(new CustomerExportDto
                {
                    Name = customer.Name,
                    SpentMoney = customer.Sales.Sum(x => x.Car.Parts.Sum(y => y.Part.Price)),
                    BoughtCars = customer.Sales.Count
                });
            }

            serializer.Serialize(writer, customersDtos);
        }
    }
}
