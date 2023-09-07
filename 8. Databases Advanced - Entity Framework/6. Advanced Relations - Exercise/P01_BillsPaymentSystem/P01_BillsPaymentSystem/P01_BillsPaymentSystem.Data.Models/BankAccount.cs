using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Data.Models
{
    public class BankAccount
    {
        public int BankAccountId { get; set; }
        public decimal Balance { get; set; }
        public string BankName { get; set; }
        public string SWIFTCode { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount) 
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
        }
    }
}
