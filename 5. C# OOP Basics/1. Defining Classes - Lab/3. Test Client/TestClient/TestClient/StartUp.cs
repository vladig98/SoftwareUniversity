using System;
using System.Collections.Generic;
using System.Linq;

namespace TestClient
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            const string end = "End";

            string input = Console.ReadLine();

            List<BankAccount> accounts = new List<BankAccount>();

            while (input != end)
            {
                string[] inputTokens = input.Split(' ');

                switch (inputTokens[0])
                {
                    case "Create":
                        Create(inputTokens.Skip(1).ToArray(), accounts);
                        break;
                    case "Deposit":
                        Deposti(inputTokens.Skip(1).ToArray(), accounts);
                        break;
                    case "Withdraw":
                        Withdraw(inputTokens.Skip(1).ToArray(), accounts);
                        break;
                    case "Print":
                        Print(inputTokens.Skip(1).ToArray(), accounts);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        private static void Print(string[] inputTokens, List<BankAccount> accounts)
        {
            if (accounts.Any(x => x.Id == int.Parse(inputTokens[0])))
            {
                Console.WriteLine(accounts.FirstOrDefault(x => x.Id == int.Parse(inputTokens[0])));
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Withdraw(string[] inputTokens, List<BankAccount> accounts)
        {
            if (accounts.Any(x => x.Id == int.Parse(inputTokens[0])))
            {
                BankAccount acccount = accounts.FirstOrDefault(x => x.Id == int.Parse(inputTokens[0]));
                if (acccount.Balance - int.Parse(inputTokens[1]) < 0)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    acccount.Withdraw(int.Parse(inputTokens[1]));
                }
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Deposti(string[] inputTokens, List<BankAccount> accounts)
        {
            if (accounts.Any(x => x.Id == int.Parse(inputTokens[0])))
            {
                accounts.FirstOrDefault(x => x.Id == int.Parse(inputTokens[0])).Deposit(int.Parse(inputTokens[1]));
            }
            else
            {
                Console.WriteLine("Account does not exist");
            }
        }

        private static void Create(string[] inputTokens, List<BankAccount> accounts)
        {
            if (!accounts.Any(x => x.Id == int.Parse(inputTokens[0])))
            {
                accounts.Add(new BankAccount { Id = int.Parse(inputTokens[0]) });
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }
    }
}
