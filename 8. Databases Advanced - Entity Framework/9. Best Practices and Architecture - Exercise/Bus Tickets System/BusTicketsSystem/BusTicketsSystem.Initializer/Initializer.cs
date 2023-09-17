using BusTicketsSystem.Data;
using BusTicketsSystem.Initializer.ModelInitializers;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusTicketsSystem.Initializer
{
    public class Initializer
    {
        private readonly BusTicketsSystemContext context;

        public Initializer(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            if (!context.BusCompanies.Any())
            {
                InsertBusCompanies();
            }
            if (!context.Towns.Any())
            {
                InsertTowns();
            }
            if (!context.Customers.Any())
            {
                InsertCustomers();
            }
            if (!context.BusStations.Any())
            {
                InsertBusStations();
            }
            if (!context.Trips.Any())
            {
                InsertTrips();
            }
            if (!context.Tickets.Any())
            {
                InsertTickets();
            }
            if (!context.Reviews.Any())
            {
                InsertReviews();
            }
            if (!context.BankAccounts.Any())
            {
                InsertBankAccounts();
            }
        }

        private void InsertTrips()
        {
            var trips = TripsInitializer.GetTrips();

            for (int i = 0; i < trips.Length; i++)
            {
                if (IsValid(trips[i]))
                {
                    context.Trips.Add(trips[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertTowns()
        {
            var towns = TownsInitializer.GetTowns();

            for (int i = 0; i < towns.Length; i++)
            {
                if (IsValid(towns[i]))
                {
                    context.Towns.Add(towns[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertTickets()
        {
            var tickets = TicketsInitializer.GetTickets();

            for (int i = 0; i < tickets.Length; i++)
            {
                if (IsValid(tickets[i]))
                {
                    context.Tickets.Add(tickets[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertReviews()
        {
            var reviews = ReviewsInitializer.GetReviews();

            for (int i = 0; i < reviews.Length; i++)
            {
                if (IsValid(reviews[i]))
                {
                    context.Reviews.Add(reviews[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertCustomers()
        {
            var customers = CustomersInitializer.GetCustomers();

            for (int i = 0; i < customers.Length; i++)
            {
                if (IsValid(customers[i]))
                {
                    context.Customers.Add(customers[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertBusStations()
        {
            var busStations = BusStationsInitializer.GetBusStations();

            for (int i = 0; i < busStations.Length; i++)
            {
                if (IsValid(busStations[i]))
                {
                    context.BusStations.Add(busStations[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertBankAccounts()
        {
            var bankAccounts = BankAccountsInitializer.GetBankAccounts();

            for (int i = 0; i < bankAccounts.Length; i++)
            {
                if (IsValid(bankAccounts[i]))
                {
                    context.BankAccounts.Add(bankAccounts[i]);
                }
            }

            context.SaveChanges();
        }

        private void InsertBusCompanies()
        {
            var busCompanies = BusCompaniesInitializer.GetBusCompanies();

            for (int i = 0; i < busCompanies.Length; i++)
            {
                if (IsValid(busCompanies[i]))
                {
                    context.BusCompanies.Add(busCompanies[i]);
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
