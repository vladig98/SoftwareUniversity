using BusTicketsSystem.Models;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class TicketsInitializer
    {
        public static Ticket[] GetTickets()
        {
            Ticket[] tickets = new Ticket[]
            {
                new Ticket() { CustomerId = 1, Price = 19.99m, Seat = "A1", TripId = 1 },
                new Ticket() { CustomerId = 2, Price = 15.99m, Seat = "A2", TripId = 2 },
                new Ticket() { CustomerId = 3, Price = 13.99m, Seat = "A3", TripId = 3 },
                new Ticket() { CustomerId = 4, Price = 19.99m, Seat = "B1", TripId = 4 },
                new Ticket() { CustomerId = 5, Price = 19.99m, Seat = "B2", TripId = 5 },
                new Ticket() { CustomerId = 6, Price = 11.99m, Seat = "B3", TripId = 6 },
                new Ticket() { CustomerId = 7, Price = 9.99m, Seat = "C1", TripId = 7 },
                new Ticket() { CustomerId = 8, Price = 29.99m, Seat = "C2", TripId = 8 },
                new Ticket() { CustomerId = 9, Price = 9.99m, Seat = "C3", TripId = 9 },
                new Ticket() { CustomerId = 10, Price = 19.99m, Seat = "D1", TripId = 10 }
            };

            return tickets;
        }
    }
}
