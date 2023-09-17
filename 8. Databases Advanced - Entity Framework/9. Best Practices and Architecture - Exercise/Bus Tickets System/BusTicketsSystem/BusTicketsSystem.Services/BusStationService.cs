using BusTicketsSystem.Services.Contracts;
using System.Collections.Generic;
using System;
using BusTicketsSystem.Models;
using BusTicketsSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AutoMapper.QueryableExtensions;

namespace BusTicketsSystem.Services
{
    public class BusStationService : IBusStationService
    {
        private readonly BusTicketsSystemContext context;

        public BusStationService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public bool Exist(int id)
            => ById<BusStation>(id) != null;

        public bool Exist(string name) 
            => ByName<BusStation>(name) != null;

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id == id).SingleOrDefault();

        public TModel ByName<TModel>(string name)
            => By<TModel>(x => x.Name == name).SingleOrDefault();

        private IEnumerable<TModel> By<TModel>(Func<BusStation, bool> predicate)
            => context.BusStations.Include(x => x.OriginTrips).Include(x => x.DestinationTrips).Include(x => x.Town).Where(predicate)
            .AsQueryable().ProjectTo<TModel>();
    }
}
