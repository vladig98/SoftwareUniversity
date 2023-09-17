using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Contracts;
using System.Collections.Generic;
using System;
using System.Linq;
using BusTicketsSystem.Data;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsSystem.Services
{
    public class TicketService : ITicketService
    {
        private readonly BusTicketsSystemContext context;

        public TicketService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public Ticket BuyTicket(int customerId, int tripId, decimal price, string seat)
        {
            var ticket = new Ticket
            {
                CustomerId = customerId,
                TripId = tripId,
                Price = price,
                Seat = seat
            };

            context.Customers.Where(x => x.Id == customerId).First().BankAccount.Balance -= price;

            context.Tickets.Add(ticket);
            context.SaveChanges();

            return ticket;
        }

        public bool Exist(int id)
            => ById<Ticket>(id) != null;

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id == id).SingleOrDefault();

        private IEnumerable<TModel> By<TModel>(Func<Ticket, bool> predicate)
            => context.Tickets.Include(x => x.Trip).Include(x => x.Customer).Where(predicate).AsQueryable().ProjectTo<TModel>();
    }
}
