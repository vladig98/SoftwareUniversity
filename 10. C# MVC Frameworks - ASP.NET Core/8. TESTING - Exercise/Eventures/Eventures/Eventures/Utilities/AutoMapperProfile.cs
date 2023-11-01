using AutoMapper;
using Eventures.DbModels;
using Eventures.Models;

namespace Eventures.Utilities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LoginViewModel, User>();
            CreateMap<RegisterViewModel, User>();
            CreateMap<ExternalLoginViewModel, User>();
            CreateMap<EventViewModel, EventuresEvent>();
            CreateMap<OrderViewModel, Order>().ForMember(dest => dest.TicketsCount, opt => opt.MapFrom(x => x.Tickets));
        }
    }
}
