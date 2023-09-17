using BusTicketsSystem.Data;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using AutoMapper.QueryableExtensions;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Services
{
    public class TripService : ITripService
    {
        private readonly BusTicketsSystemContext context;

        public TripService(BusTicketsSystemContext context)
        {
            this.context = context;
        }

        public TModel ById<TModel>(int id)
            => By<TModel>(x => x.Id == id).SingleOrDefault();

        public bool Exist(int id)
            => ById<Trip>(id) != null;

        public ArrivedTrip UpdateStatus(int tripId, Status status)
        {
            var trip = context.Trips.Where(x => x.Id == tripId).First();

            trip.Status = status;

            context.SaveChanges();

            ArrivedTrip arrivedTrip = null;

            if (status == Status.Arrived)
            {
                arrivedTrip = new ArrivedTrip
                {
                    ActualArrivalTime = DateTime.Now,
                    DestinationBusStationId = trip.DestinationBusStationId,
                    OriginBusStationId = trip.OriginBusStationId,
                    PassengersCount = trip.Tickets.Count
                };

                context.ArrivedTrips.Add(arrivedTrip);
                context.SaveChanges();
            }

            return arrivedTrip;
        }

        private IEnumerable<TModel> By<TModel>(Func<Trip, bool> predicate)
            => context.Trips.Include(x => x.BusCompany).Include(x => x.DestinationBusStation).Include(x => x.OriginBusStation)
            .Include(x => x.Tickets).Where(predicate)
            .AsQueryable().ProjectTo<TModel>();
    }
}
