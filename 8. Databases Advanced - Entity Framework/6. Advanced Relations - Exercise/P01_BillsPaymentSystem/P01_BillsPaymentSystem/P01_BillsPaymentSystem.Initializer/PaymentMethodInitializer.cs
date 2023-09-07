using P01_BillsPaymentSystem.Data.Models;
using P01_BillsPaymentSystem.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Initializer
{
    public class PaymentMethodInitializer
    {
        public static PaymentMethod[] GetPaymentMethods()
        {
            PaymentMethod[] paymentMethods = new PaymentMethod[]
            {
                new PaymentMethod() { UserId = 1, BankAccountId = 1, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 1, CreditCardId = 1, Type = PaymentMethodType.CreditCard },
                new PaymentMethod() { UserId = 2, BankAccountId = 2, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 3, BankAccountId = 3, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 3, CreditCardId = 2, Type = PaymentMethodType.CreditCard },
                new PaymentMethod() { UserId = 4, BankAccountId = 4, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 5, CreditCardId = 3, Type = PaymentMethodType.CreditCard },
                new PaymentMethod() { UserId = 5, CreditCardId = 4, Type = PaymentMethodType.CreditCard },
                new PaymentMethod() { UserId = 6, BankAccountId = 5, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 7, BankAccountId = 6, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 7, CreditCardId = 5, Type = PaymentMethodType.CreditCard },
                new PaymentMethod() { UserId = 7, CreditCardId = 6, Type = PaymentMethodType.CreditCard },
                new PaymentMethod() { UserId = 8, BankAccountId = 7, Type = PaymentMethodType.BankAccount },
                new PaymentMethod() { UserId = 8, CreditCardId = 7, Type = PaymentMethodType.CreditCard }
            };

            return paymentMethods;
        }
    }
}
