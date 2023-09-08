using AutoMapper;
using Pizzeria.App.Core.Dtos;
using Pizzeria.Models;

namespace Pizzeria.App.Core
{
    public class PizzeriaProfile : Profile
    {
        public PizzeriaProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, ManagerDto>().ForMember(x => x.EmployeesDto, y => y.MapFrom(z => z.ManagerEmployees)).ReverseMap();
            CreateMap<Employee, EmployeePersonalInfoDto>().ReverseMap();
            CreateMap<Employee, ListEmployeeDto>().ReverseMap();
        }
    }
}
