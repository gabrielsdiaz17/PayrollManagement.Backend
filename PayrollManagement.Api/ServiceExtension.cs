using PayrollManagement.Api.ModuleWorker.Interfaces;
using PayrollManagement.Api.ModuleWorker.Services;

namespace PayrollManagement.Api
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddCustomizedServices(this IServiceCollection services)
        {
            services.AddTransient<IWorkerService, WorkerService>();
            return services;
        }
    }
}
