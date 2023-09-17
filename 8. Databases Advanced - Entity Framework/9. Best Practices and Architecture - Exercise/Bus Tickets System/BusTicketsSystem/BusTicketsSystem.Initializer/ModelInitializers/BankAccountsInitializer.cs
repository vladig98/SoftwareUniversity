using BusTicketsSystem.Models;

namespace BusTicketsSystem.Initializer.ModelInitializers
{
    public class BankAccountsInitializer
    {
        public static BankAccount[] GetBankAccounts()
        {
            BankAccount[] bankAccounts = new BankAccount[]
            {
                new BankAccount() { AccountNumber = "86063057", Balance = 58224.69m, CustomerId = 1 },
                new BankAccount() { AccountNumber = "86063046", Balance = 43884.93m, CustomerId = 2 },
                new BankAccount() { AccountNumber = "99081536", Balance = 27450.24m, CustomerId = 3 },
                new BankAccount() { AccountNumber = "41345938", Balance = 615.12m, CustomerId = 4 },
                new BankAccount() { AccountNumber = "46319531", Balance = 93581.08m, CustomerId = 5 },
                new BankAccount() { AccountNumber = "55073835", Balance = 33003.69m, CustomerId = 6 },
                new BankAccount() { AccountNumber = "021000021", Balance = 5040.76m, CustomerId = 7 },
                new BankAccount() { AccountNumber = "011401533", Balance = 35542.13m, CustomerId = 8 },
                new BankAccount() { AccountNumber = "091000019", Balance = 86382.85m, CustomerId = 9 },
                new BankAccount() { AccountNumber = "00202 899", Balance = 2535.88m, CustomerId = 10 }
            };

            return bankAccounts;
        }
    }
}
