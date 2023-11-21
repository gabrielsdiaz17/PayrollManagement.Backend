using AutoMapper;
using PayrollManagement.Api.ModuleCity.ViewModel;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.Profiles
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<CityViewModel, City>().ReverseMap();
        }
    }
    
}
