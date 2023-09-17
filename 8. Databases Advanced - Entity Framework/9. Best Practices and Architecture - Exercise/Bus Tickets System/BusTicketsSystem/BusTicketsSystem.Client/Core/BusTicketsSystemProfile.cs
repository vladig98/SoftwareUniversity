using AutoMapper;
using BusTicketsSystem.Client.Core.Dtos;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Client.Core
{
    public class BusTicketsSystemProfile : Profile
    {
        public BusTicketsSystemProfile()
        {
            CreateMap<BankAccount, BankAccount>();
            CreateMap<BusCompany, BusCompany>();
            CreateMap<BusStation, BusStation>();
            CreateMap<Customer, Customer>();
            CreateMap<Review, Review>();
            CreateMap<Ticket, Ticket>();
            CreateMap<Town, Town>();
            CreateMap<Trip, Trip>();

            CreateMap<BusStation, BusStationDto>()
                .ForMember(x => x.OriginTrips, y => y.MapFrom(z => z.OriginTrips))
                .ForMember(x => x.DestinationTrips, y => y.MapFrom(z => z.DestinationTrips))
                .ForMember(x => x.Town, y => y.MapFrom(z => z.Town))
                .ReverseMap();

            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Trip, TripDto>().ReverseMap();
            CreateMap<Review, ReviewDto>().ReverseMap();
            CreateMap<BusCompany, BusCompanyDto>().ReverseMap();
        }
    }
}
