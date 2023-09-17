using BusTicketsSystem.Data;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using AutoMapper.QueryableExtensions;

namespace BusTicketsSystem.Services
{
    public class BusCompanyService : IBusCompanyService
    {
        private readonly BusTicketsSystemContext context;

        public BusCompanyService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id ==  id).SingleOrDefault();

        public TModel ByName<TModel>(string name)
            => By<TModel>(x => x.Name == name).SingleOrDefault();

        public bool Exist(int id)
            => ById<BusCompany>(id) != null;

        public bool Exist(string name)
            => ByName<BusCompany>(name) != null;

        private IEnumerable<TModel> By<TModel>(Func<BusCompany, bool> predicate)
            => context.BusCompanies.Include(x => x.Trips).Include(x => x.Reviews).ThenInclude(x => x.Customer)
            .Where(predicate).AsQueryable().ProjectTo<TModel>();
    }
}
