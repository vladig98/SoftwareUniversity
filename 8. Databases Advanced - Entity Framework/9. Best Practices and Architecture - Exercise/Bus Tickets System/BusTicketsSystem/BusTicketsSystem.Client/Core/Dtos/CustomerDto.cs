using BusTicketsSystem.Models;

namespace BusTicketsSystem.Client.Core.Dtos
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
