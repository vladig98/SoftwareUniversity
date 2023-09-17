using BusTicketsSystem.Models;
using System;

namespace BusTicketsSystem.Client.Core.Dtos
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public double Grade { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateAndTimeOfPublishing { get; set; }
    }
}
