using BusTicketsSystem.Client.Core.Contracts;
using BusTicketsSystem.Client.Core.Dtos;
using BusTicketsSystem.Services.Contracts;
using System;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class BuyTicketCommand : ICommand
    {
        private readonly ITicketService ticketService;
        private readonly ICustomerService customerService;
        private readonly ITripService tripService;

        public BuyTicketCommand(ITicketService ticketService, ICustomerService customerService, ITripService tripService)
        {
            this.ticketService = ticketService;
            this.customerService = customerService;
            this.tripService = tripService;
        }

        public string Execute(string[] args)
        {
            if (args.Length != 4)
            {
                throw new ArgumentException("Invalid data.");
            }

            var isCustomerIdValid = int.TryParse(args[0], out int customerId);
            var isTripId = int.TryParse(args[1], out int tripId);
            var isPriceValid = decimal.TryParse(args[2], out decimal price);
            string seat = args[3];

            if (!isCustomerIdValid || !isTripId || !isPriceValid || string.IsNullOrEmpty(seat) || string.IsNullOrWhiteSpace(seat))
            {
                throw new ArgumentException("Invalid data.");
            }

            var customerExists = customerService.Exist(customerId);

            if (!customerExists)
            {
                throw new ArgumentException("Customer not found!");
            }

            var tripExists = tripService.Exist(tripId);

            if (!tripExists)
            {
                throw new ArgumentException("Trip not found!");
            }

            if (price <= 0)
            {
                throw new ArgumentException("Invalid price!");
            }

            var customer = customerService.ById<CustomerDto>(customerId);

            if (customer.BankAccount.Balance - price < 0)
            {
                return $"Insufficient amount of money for customer {customer.FirstName} {customer.LastName} with " +
                    $"bank account number {customer.BankAccount.AccountNumber}";
            }

            var ticket = ticketService.BuyTicket(customerId, tripId, price, seat);

            return $"Customer {ticket.Customer.FirstName} {ticket.Customer.LastName} " +
                $"bought ticket for trip {tripId} for ${price:F2} on seat {seat}";
        }
    }
}
