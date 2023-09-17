using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Contracts;
using System.Collections.Generic;
using System;
using BusTicketsSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper.QueryableExtensions;

namespace BusTicketsSystem.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly BusTicketsSystemContext context;

        public CustomerService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id == id).SingleOrDefault();

        public TModel ByName<TModel>(string name)
            => By<TModel>(x => x.FirstName == name).SingleOrDefault();

        public bool Exist(int id)
            => ById<Customer>(id) != null;

        public bool Exist(string name)
            => ByName<Customer>(name) != null;

        private IEnumerable<TModel> By<TModel>(Func<Customer, bool> predicate)
            => context.Customers.Include(x => x.BankAccount).Include(x => x.Reviews).Include(x => x.HomeTown).Where(predicate)
            .AsQueryable().ProjectTo<TModel>();
    }
}
