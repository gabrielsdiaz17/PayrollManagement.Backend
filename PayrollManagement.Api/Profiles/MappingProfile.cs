using AutoMapper;
using PayrollManagement.Api.ModuleCity.ViewModel;
using PayrollManagement.Api.ModuleCompany.ViewModel;
using PayrollManagement.Api.ModuleCostcenter.ViewModel;
using PayrollManagement.Api.ModuleRole.ViewModel;
using PayrollManagement.Api.ModuleUser.ViewModel;
using PayrollManagement.Api.ModuleUserInfo.Services;
using PayrollManagement.Api.ModuleWorker.ViewModels;
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
    public class CompanyMappingProfile : Profile
    {
        public CompanyMappingProfile()
        {
            CreateMap<CompanyViewModel, Company>().ReverseMap();
        }
    }
    public class CompanySearchMappingProfile : Profile
    {
        public CompanySearchMappingProfile()
        {
            CreateMap<Company, CompanySearchViewModel>()
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City));
        }
    }

    public class CostCenterMappingProfile : Profile
    {
        public CostCenterMappingProfile()
        {
            CreateMap<CostCenter, CostCenterViewModel>().ReverseMap();
        }
    }
    public class RoleMappingProfile : Profile
    {
        public RoleMappingProfile()
        {
            CreateMap<Role, RoleViewModel>().ReverseMap();
        }
    }
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
    public class UserInfoMappingProfile : Profile
    {
        public UserInfoMappingProfile()
        {
            CreateMap<UserInfo, UserInfoViewModel>().ReverseMap();
        }
    }
    public class WorkerMappingProfile : Profile
    {
        public WorkerMappingProfile()
        {
            CreateMap<Worker, WorkerViewModel>().ReverseMap();
        }
    }
}
