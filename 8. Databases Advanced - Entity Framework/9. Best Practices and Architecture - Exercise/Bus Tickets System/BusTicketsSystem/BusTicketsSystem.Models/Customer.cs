using BusTicketsSystem.Models.Enums;
using System;
using System.Collections.Generic;

namespace BusTicketsSystem.Models
{
    public class Customer
    {
        public Customer()
        {
            Reviews = new HashSet<Review>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int HomeTownId { get; set; }
        public Town HomeTown { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
