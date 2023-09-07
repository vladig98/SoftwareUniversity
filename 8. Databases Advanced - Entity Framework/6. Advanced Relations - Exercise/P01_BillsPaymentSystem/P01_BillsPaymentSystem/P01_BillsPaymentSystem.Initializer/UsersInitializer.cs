using P01_BillsPaymentSystem.Data.Models.Enums;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Initializer
{
    public class UsersInitializer
    {
        public static User[] GetUsers()
        {
            User[] users = new User[]
            {
                new User() { FirstName = "Gosho", LastName = "Goshev", Email = "gosho@softuni.bg", Password = "gdgs1243241" },
                new User() { FirstName = "Ivan", LastName = "Petrov", Email = "ivanpetrov@softuni.bg", Password = "fsdfds23131" },
                new User() { FirstName = "Kiro", LastName = "Botev", Email = "kirobotev@softuni.bg", Password = "fsdfsdf21312" },
                new User() { FirstName = "Miro", LastName = "Bobchev", Email = "fakeprofile@softuni.bg", Password = "fdsafdsf1231" },
                new User() { FirstName = "Rosen", LastName = "Stoyanov", Email = "hacker@softuni.bg", Password = "fsdfsa1212" },
                new User() { FirstName = "Stoyan", LastName = "Stanev", Email = "crazyBoy@softuni.bg", Password = "fasdfas121" },
                new User() { FirstName = "Dobromir", LastName = "Shopov", Email = "lazyBoy@softuni.bg", Password = "fasfa111" },
                new User() { FirstName = "Mitko", LastName = "Stanev", Email = "1fdaf@softuni.bg", Password = "fasfadsf12123" },
                new User() { FirstName = "Vladimir", LastName = "Damyanovski", Email = "fsaf@softuni.bg", Password = "fsadfasddf214e23r523" },
                new User() { FirstName = "Niki", LastName = "Penchev", Email = "nqmaemail@softuni.bg", Password = "sfdfwf32432" },
                new User() { FirstName = "Miro", LastName = "Stamatov", Email = "test123@softuni.bg", Password = "sdgsg423412" },
                new User() { FirstName = "Stamat", LastName = "Kolev", Email = "rlzmad@softuni.bg", Password = "sdgsg23124" },
                new User() { FirstName = "Hristo", LastName = "Stoichkov", Email = "ldufen@softuni.bg", Password = "gsdg3425432" }
            };

            return users;
        }
    }
}
