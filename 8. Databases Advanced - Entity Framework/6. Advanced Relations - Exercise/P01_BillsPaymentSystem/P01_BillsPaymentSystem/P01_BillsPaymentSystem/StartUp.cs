using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using P01_BillsPaymentSystem.Initializer;
using System;
using System.Globalization;
using System.Linq;

namespace P01_BillsPaymentSystem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            BillsPaymentSystemContext context = new BillsPaymentSystemContext();

            

            using (context)
            {
                //Populate tables
                //Initializer.Initializer.Seed(context);

                User user = GetUser(context);

                //PrintUserInfo(user);
                PayBills(user, 800);
            }
        }

        private static User GetUser(BillsPaymentSystemContext context)
        {
            int userId = int.Parse(Console.ReadLine());

            User user = context.Users.Where(x => x.UserId == userId)
                    .Include(x => x.PaymentMethods)
                    .ThenInclude(x => x.BankAccount)
                    .Include(x => x.PaymentMethods)
                    .ThenInclude(x => x.CreditCard).FirstOrDefault();

            if (user == null)
            {
                Console.WriteLine($"User with id {userId} not found!");
                return null;
            }

            return user;
        }

        private static void PrintUserInfo(User user)
        {
            Console.WriteLine($"User: {user.FirstName} {user.LastName}");
            Console.WriteLine("Bank Accounts:");
            foreach (var item in user.PaymentMethods.Where(x => x.BankAccountId != null))
            {
                Console.WriteLine($"-- ID: {item.BankAccount.BankAccountId}");
                Console.WriteLine($"--- Balance: {item.BankAccount.Balance:F2}");
                Console.WriteLine($"--- Bank: {item.BankAccount.BankName}");
                Console.WriteLine($"--- SWIFT: {item.BankAccount.SWIFTCode}");
            }
            Console.WriteLine("Credit Cards:");
            foreach (var item in user.PaymentMethods.Where(x => x.CreditCardId != null))
            {
                Console.WriteLine($"-- ID: {item.CreditCard.CreditCardId}");
                Console.WriteLine($"--- Limit: {item.CreditCard.Limit:F2}");
                Console.WriteLine($"--- Money Owed: {item.CreditCard.MoneyOwed:F2}");
                Console.WriteLine($"--- Limit Left: {item.CreditCard.LimitLeft:F2}");
                Console.WriteLine($"--- Expiration Date: {item.CreditCard.ExpirationDate.ToString("yyyy/MM", CultureInfo.InvariantCulture)}");
            }
        }

        private static void PayBills(User user, decimal amount)
        {
            var bankAccountsTotal = user.PaymentMethods.Where(x => x.BankAccount != null).Sum(x => x.BankAccount.Balance);
            var creditCardsTotal = user.PaymentMethods.Where(x => x.CreditCard != null).Sum(x => x.CreditCard.LimitLeft);

            var total = bankAccountsTotal + creditCardsTotal;

            var bankAccounts = user.PaymentMethods.Where(x => x.BankAccount != null).Select(x => x.BankAccount)
                .OrderBy(x => x.BankAccountId).ToList();
            var creditCards = user.PaymentMethods.Where(x => x.CreditCard != null).Select(x => x.CreditCard)
                .OrderBy(x => x.CreditCardId).ToList();

            if (total - amount >= 0)
            {
                foreach (var bankAccount in bankAccounts)
                {
                    if (bankAccount.Balance - amount >= 0)
                    {
                        bankAccount.Withdraw(amount);
                        amount -= bankAccount.Balance;
                    }
                    else
                    {
                        amount -= bankAccount.Balance;
                        bankAccount.Withdraw(bankAccount.Balance);
                    }

                    if (amount <= 0)
                    {
                        return;
                    }
                }

                foreach (var creditCard in creditCards)
                {
                    if (creditCard.LimitLeft - amount >= 0)
                    {
                        creditCard.Withdraw(amount);
                        amount -= creditCard.LimitLeft;
                    }
                    else
                    {
                        amount -= creditCard.LimitLeft;
                        creditCard.Withdraw(creditCard.LimitLeft);
                    }

                    if (amount <= 0)
                    {
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
            }
        }
    }
}
