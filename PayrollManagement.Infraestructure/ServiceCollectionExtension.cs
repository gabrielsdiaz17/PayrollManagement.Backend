using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayrollManagement.Business.ModuleCostCenter.Interfaces;
using PayrollManagement.Business.ModuleCostCenter.Services;
using PayrollManagement.Infraestructure.Data;
using PayrollManagement.Infraestructure.Repository;


namespace PayrollManagement.Infraestructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCustomaizedDataStore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                 options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
        public static IServiceCollection AddCustomizedRepository(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
        public static IServiceCollection AddCustomerServices(this IServiceCollection services)
        {

            //services.AddTransient<ICostCenterService, CostCenterService>();
            //services.AddTransient<IWorkerService, WorkerService>();
            return services;
        }
    }
}