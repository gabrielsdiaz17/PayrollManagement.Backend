using PayrollManagement.Api.ModuleCompany.Interfaces;
using PayrollManagement.Api.ModuleCompany.Services;
using PayrollManagement.Api.ModuleCostcenter.Interfaces;
using PayrollManagement.Api.ModuleCostcenter.Services;
using PayrollManagement.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Api.ModuleUserActivity.Services;
using PayrollManagement.Api.ModuleWorker.Interfaces;
using PayrollManagement.Api.ModuleWorker.Services;

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
            return services;
        }
    }
}
