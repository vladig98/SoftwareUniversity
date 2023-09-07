using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Initializer
{
    internal class BankAccountInitializer
    {
        public static BankAccount[] GetBankAccounts()
        {
            BankAccount[] bankAccounts = new BankAccount[]
            {
                new BankAccount() { BankName = "Crazy Bank", SWIFTCode = "CRB", Balance = 2320.50M },
                new BankAccount() { BankName = "Lazy Bank", SWIFTCode = "LB", Balance = 1220.20M },
                new BankAccount() { BankName = "New Bank", SWIFTCode = "NBB", Balance = 3204.03M },
                new BankAccount() { BankName = "Evil Bank", SWIFTCode = "EB", Balance = 3120.00M },
                new BankAccount() { BankName = "BR Bank", SWIFTCode = "BRB", Balance = 765.00M },
                new BankAccount() { BankName = "Z Bank", SWIFTCode = "IB", Balance = 30.00M },
                new BankAccount() { BankName = "B Bank", SWIFTCode = "BB", Balance = 0.10M },
                new BankAccount() { BankName = "NoName Bank", SWIFTCode = "NNB", Balance = 234.30M },
                new BankAccount() { BankName = "Medina Bank", SWIFTCode = "MB", Balance = 52.31M },
                new BankAccount() { BankName = "Happy Bank", SWIFTCode = "HP", Balance = 32320.00M },
                new BankAccount() { BankName = "Poor Bank", SWIFTCode = "PB", Balance = 3220.90M },
                new BankAccount() { BankName = "Rich Bank", SWIFTCode = "RB", Balance = 9120.30M }
            };

            return bankAccounts;
        }
    }
}
