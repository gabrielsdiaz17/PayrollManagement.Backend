﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayrollManagement.Infraestructure.Contracts;
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
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            return services;
        }
    }
}