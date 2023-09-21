using CarDealer.Data;
using CarDealer.Models;
using CarDealer.Services.Contracts;
using CarDealer.Services.Dtos;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CarDealer.Services
{
    public class DatabaseDataSeeder : IDatabaseDataSeeder
    {
        private readonly CarDealerDbContext context;
        private string pathToResources = Directory.GetCurrentDirectory() + @"..\..\..\..\..\Resources\";
        private int[] discounts = new int[] { 0, 5, 10, 15, 20, 30, 40, 50 };

        public DatabaseDataSeeder(CarDealerDbContext context)
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
            List<Sale> sales = new List<Sale>();

            Random rnd = new Random();

            int numberOfSales = rnd.Next(50, 101);

            for (int i = 0; i < numberOfSales; i++)
            {
                int carIndex = rnd.Next(0, context.Cars.Count());

                int carId = context.Cars.ToList().ElementAt(carIndex).Id;

                int customerIndex = rnd.Next(0, context.Customers.Count());

                int customerId = context.Customers.ToList().ElementAt(customerIndex).Id;

                int discountIndex = rnd.Next(0, discounts.Length);

                while (sales.Any(x => x.Car_Id == carId && x.Customer_Id == customerId))
                {
                    carIndex = rnd.Next(0, context.Cars.Count());
                    carId = context.Cars.ToList().ElementAt(carIndex).Id;
                    customerIndex = rnd.Next(0, context.Customers.Count());
                    customerId = context.Customers.ToList().ElementAt(customerIndex).Id;
                }

                while (sales.Any(x => x.Car_Id == carId))
                {
                    carIndex = rnd.Next(0, context.Cars.Count());
                    carId = context.Cars.ToList().ElementAt(carIndex).Id;
                }

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
            string customersXML = File.ReadAllText(pathToResources + "customers.xml");

            var serializer = new XmlSerializer(typeof(CustomerDto[]), new XmlRootAttribute("customers"));
            var deserializedCustomers = (CustomerDto[])serializer.Deserialize(new StringReader(customersXML));

            foreach (CustomerDto customer in deserializedCustomers)
            {
                if (IsValid(customer))
                {
                    context.Customers.Add(new Customer
                    {
                        BirthDate = customer.BirthDate,
                        IsYoungDriver = customer.IsYoungDriver,
                        Name = customer.Name
                    });
                }
            }

            context.SaveChanges();
        }

        private void InsertCars()
        {
            string carsXML = File.ReadAllText(pathToResources + "cars.xml");

            var serializer = new XmlSerializer(typeof(CarDto[]), new XmlRootAttribute("cars"));
            var deserializedCars = (CarDto[])serializer.Deserialize(new StringReader(carsXML));

            foreach (var car in deserializedCars)
            {
                if (IsValid(car))
                {
                    context.Cars.Add(new Car
                    {
                        Make = car.Make,
                        Model = car.Model,
                        TraveledDistance = car.TraveledDistance
                    });
                }
            }

            context.SaveChanges();
            AssignPartsToCars();
        }

        private void AssignPartsToCars()
        {
            Random rnd = new Random();

            var cars = context.Cars.ToList();

            foreach (var car in cars)
            {
                var numberOfParts = rnd.Next(10, 21);

                List<PartCar> partCars = new List<PartCar>();

                for (int i = 0; i < numberOfParts; i++)
                {
                    int partIndex = rnd.Next(0, context.Parts.Count());

                    int partId = context.Parts.ToList().ElementAt(partIndex).Id;

                    while (partCars.Where(x => x.Car_Id == car.Id).Any(x => x.Part_Id == partId))
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
            string partsXML = File.ReadAllText(pathToResources + "parts.xml");

            var serializer = new XmlSerializer(typeof(PartDto[]), new XmlRootAttribute("parts"));
            var deserializedParts = (PartDto[])serializer.Deserialize(new StringReader(partsXML));

            Random rnd = new Random();

            foreach (var part in deserializedParts)
            {
                if (IsValid(part))
                {
                    int supplierIndex = rnd.Next(0, context.Suppliers.Count());

                    int supplierId = context.Suppliers.ToList().ElementAt(supplierIndex).Id;

                    context.Parts.Add(new Part
                    {
                        Name = part.Name,
                        Price = part.Price,
                        Quantity = part.Quantity,
                        Supplier_Id = supplierId
                    });
                }
            }

            context.SaveChanges();
        }

        private void InsertSuppliers()
        {
            string suppliersXML = File.ReadAllText(pathToResources + "suppliers.xml");

            var serializer = new XmlSerializer(typeof(SupplierDto[]), new XmlRootAttribute("suppliers"));
            var deserializedSuppliers = (SupplierDto[])serializer.Deserialize(new StringReader(suppliersXML));

            foreach (var supplier in deserializedSuppliers)
            {
                if (IsValid(supplier))
                {
                    context.Suppliers.Add(new Supplier
                    {
                        Name = supplier.Name,
                        IsImporter = supplier.IsImporter
                    });
                }
            }

            context.SaveChanges();
        }

        private bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}
