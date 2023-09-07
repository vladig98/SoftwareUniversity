using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public decimal Limit { get; set; }
        public decimal MoneyOwed { get; set; }
        public decimal LimitLeft => Limit - MoneyOwed;
        public DateTime ExpirationDate { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                MoneyOwed -= amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (LimitLeft - amount > 0 && amount > 0)
            {
                MoneyOwed += amount;
            }
        }
    }
}
