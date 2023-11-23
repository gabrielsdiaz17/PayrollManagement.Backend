using PayrollManagement.Api.ModuleCity.Interfaces;
using PayrollManagement.Api.ModuleCity.Services;
using PayrollManagement.Api.ModuleCompany.Interfaces;
using PayrollManagement.Api.ModuleCompany.Services;
using PayrollManagement.Api.ModuleCostcenter.Interfaces;
using PayrollManagement.Api.ModuleCostcenter.Services;
using PayrollManagement.Api.ModuleRegion.Interfaces;
using PayrollManagement.Api.ModuleRegion.Services;
using PayrollManagement.Api.ModuleRole.Interfaces;
using PayrollManagement.Api.ModuleRole.Services;
using PayrollManagement.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Api.ModuleUserActivity.Services;
using PayrollManagement.Api.ModuleUserInfo.Interface;
using PayrollManagement.Api.ModuleUserInfo.Service;
using PayrollManagement.Api.ModuleWorker.Interfaces;
using PayrollManagement.Api.ModuleWorker.Services;
using AutoMapper;
using PayrollManagement.Api.Profiles;
using PayrollManagement.Api.ModuleUser.Interfaces;
using PayrollManagement.Api.ModuleUser.Services;

namespace PayrollManagement.Api
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCustomizedServices(this IServiceCollection services)
        {
            services.AddTransient<IWorkerService, WorkerService>();
            services.AddTransient<ICostCenterService, CostCenterService>();
            services.AddTransient<IUserActivityService, UserActivityService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICompanyService,CompanyService>();
            services.AddTransient<IRegionService,RegionService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IUserInfoService, UserInfoService>();
            services.AddTransient<IUserService, UserService>();
            //Mapping
            services.AddAutoMapper(typeof(ServiceExtension));
            services.AddAutoMapper(typeof(CityMappingProfile));
            services.AddAutoMapper(typeof(CompanySearchMappingProfile));
            services.AddAutoMapper(typeof(CompanyMappingProfile));
            services.AddAutoMapper(typeof(CostCenterMappingProfile));
            services.AddAutoMapper(typeof(RoleMappingProfile));
            services.AddAutoMapper(typeof(UserMappingProfile));
            services.AddAutoMapper(typeof(UserInfoMappingProfile));
            services.AddAutoMapper(typeof(WorkerMappingProfile));



            return services;
        }
    }
}
