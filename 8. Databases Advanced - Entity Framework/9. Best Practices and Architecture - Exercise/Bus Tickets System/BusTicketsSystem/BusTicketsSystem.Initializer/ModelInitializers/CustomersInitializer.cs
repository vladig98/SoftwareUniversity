using BusTicketsSystem.Models;
using BusTicketsSystem.Models.Enums;
using System;
using System.Globalization;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class CustomersInitializer
    {
        public static Customer[] GetCustomers()
        {
            Customer[] customers = new Customer[]
            {
                new Customer() { BankAccountId = 1, FirstName = "Michelle", LastName = "Raminez", 
                    DateOfBirth = DateTime.ParseExact("10/30/1961", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Female, HomeTownId = 1 },
                new Customer() { BankAccountId = 2, FirstName = "Julie", LastName = "Lees", 
                    DateOfBirth = DateTime.ParseExact("03/22/1990", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Female, HomeTownId = 2 },
                new Customer() { BankAccountId = 3, FirstName = "James", LastName = "Brown", 
                    DateOfBirth = DateTime.ParseExact("08/08/1992", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Male, HomeTownId = 3 },
                new Customer() { BankAccountId = 4, FirstName = "Carmen", LastName = "Marcell", 
                    DateOfBirth = DateTime.ParseExact("09/17/1966", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Female, HomeTownId = 4 },
                new Customer() { BankAccountId = 5, FirstName = "Tashia", LastName = "Swihart", 
                    DateOfBirth = DateTime.ParseExact("11/01/1960", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.NotSpecified, HomeTownId = 5 },
                new Customer() { BankAccountId = 6, FirstName = "Robert", LastName = "Roberts", 
                    DateOfBirth = DateTime.ParseExact("08/15/1997", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.NotSpecified, HomeTownId = 6 },
                new Customer() { BankAccountId = 7, FirstName = "James", LastName = "Gant", 
                    DateOfBirth = DateTime.ParseExact("04/21/1977", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Male, HomeTownId = 7 },
                new Customer() { BankAccountId = 8, FirstName = "Fay", LastName = "Fontaine", 
                    DateOfBirth = DateTime.ParseExact("10/13/1993", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Female, HomeTownId = 8 },
                new Customer() { BankAccountId = 9, FirstName = "Emanuel", LastName = "Rae", 
                    DateOfBirth = DateTime.ParseExact("01/08/1967", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.Male, HomeTownId = 9 },
                new Customer() { BankAccountId = 10, FirstName = "Heather", LastName = "Marrero", 
                    DateOfBirth = DateTime.ParseExact("05/30/1987", "MM/dd/yyyy", CultureInfo.InvariantCulture), 
                    Gender = Gender.NotSpecified, HomeTownId = 10 }
            };

            return customers;
        }
    }
}
