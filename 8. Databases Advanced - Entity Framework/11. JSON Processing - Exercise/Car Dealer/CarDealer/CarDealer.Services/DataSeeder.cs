using CarDealer.Data;
using CarDealer.Models;
using CarDealer.Services.Contracts;
using CarDealer.Services.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarDealer.Services
{
    public class DataSeeder : IDataSeeder
    {
        private readonly CarDealerDbContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\";
        private int[] discounts = new int[] { 0, 5, 10, 15, 20, 30, 40, 50 };

        public DataSeeder(CarDealerDbContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if (!context.Suppliers.Any())
            {
                InsertSuppliers();
            }
            if (!context.Parts.Any())
            {
                InsertParts();
            }
            if (!context.Cars.Any())
            {
                InsertCars();
            }
            if (!context.Customers.Any())
            {
                ImportCustomers();
            }
            if (!context.Sales.Any())
            {
                InsertSales();
            }
        }

        private void InsertSales()
        {
            Random rnd = new Random();

            int numberOfSales = rnd.Next(30, 51);

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < numberOfSales; i++)
            {
                int carIndex = rnd.Next(0, context.Cars.Count());
                int carId = context.Cars.ToList().ElementAt(carIndex).Id;

                int customerIndex = rnd.Next(0, context.Customers.Count());
                int customerId = context.Customers.ToList().ElementAt(customerIndex).Id;

                while (sales.Any(x => x.Car_Id == carId))
                {
                    carIndex = rnd.Next(0, context.Cars.Count());
                    carId = context.Cars.ToList().ElementAt(carIndex).Id;
                }

                int discountIndex = rnd.Next(0, discounts.Length);

                sales.Add(new Sale
                {
                    Car_Id = carId,
                    Customer_Id = customerId,
                    Discount = discounts[discountIndex]
                });
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();
        }

        private void ImportCustomers()
        {
            string customersJSON = File.ReadAllText(pathToResources + "customers.json");

            var deserializedCustomers = JsonConvert.DeserializeObject<List<CustomerDto>>(customersJSON);

            foreach (var customer in deserializedCustomers)
            {
                context.Customers.Add(new Customer
                {
                    BirthDate = customer.birthDate,
                    IsYoungDriver = customer.isYoungDriver,
                    Name = customer.name
                });
            }

            context.SaveChanges();
        }

        private void InsertCars()
        {
            string carsJSON = File.ReadAllText(pathToResources + "cars.json");

            var deserializedCars = JsonConvert.DeserializeObject<List<CarDto>>(carsJSON);

            foreach (var car in deserializedCars)
            {
                context.Cars.Add(new Car
                {
                    Make = car.make,
                    Model = car.model,
                    TraveledDistance = car.travelledDistance
                });
            }

            context.SaveChanges();
            AssignPartsToCars();
        }

        private void AssignPartsToCars()
        {
            var cars = context.Cars.ToList();

            Random rnd = new Random();

            foreach (var car in cars)
            {
                int partIndex = rnd.Next(0, context.Parts.Count());
                int partId = context.Parts.ToList().ElementAt(partIndex).Id;

                List<PartCar> partCars = new List<PartCar>();

                int numberOfParts = rnd.Next(10, 21);

                for (int i = 0; i < numberOfParts; i++)
                {
                    while (partCars.Any(x => x.Car_Id == car.Id && x.Part_Id == partId))
                    {
                        partIndex = rnd.Next(0, context.Parts.Count());
                        partId = context.Parts.ToList().ElementAt(partIndex).Id;
                    }

                    partCars.Add(new PartCar
                    {
                        Car_Id = car.Id,
                        Part_Id = partId
                    });
                }

                context.PartCars.AddRange(partCars);
            }

            context.SaveChanges();
        }

        private void InsertParts()
        {
            string partsJSON = File.ReadAllText(pathToResources + "parts.json");

            var deserializedParts = JsonConvert.DeserializeObject<List<PartDto>>(partsJSON);

            Random rnd = new Random();

            foreach (var part in deserializedParts)
            {
                int supplierIndex = rnd.Next(0, context.Suppliers.Count());
                int supplierId = context.Suppliers.ToList().ElementAt(supplierIndex).Id;

                context.Parts.Add(new Part
                {
                    Name = part.name,
                    Price = part.price,
                    Quantity = part.quantity,
                    Supplier_Id = supplierId
                });
            }

            context.SaveChanges();
        }

        private void InsertSuppliers()
        {
            string suppliersJSON = File.ReadAllText(pathToResources + "suppliers.json");

            var deserializedSuppliers = JsonConvert.DeserializeObject<List<SupplierDto>>(suppliersJSON);

            foreach (var supplier in deserializedSuppliers)
            {
                context.Suppliers.Add(new Supplier
                {
                    IsImporter = supplier.isImporter,
                    Name = supplier.name
                });
            }

            context.SaveChanges();
        }
    }
}
