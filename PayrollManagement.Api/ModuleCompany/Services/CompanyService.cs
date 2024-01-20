using Microsoft.EntityFrameworkCore;
using PayrollManagement.Api.ModuleCompany.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleCompany.Services
{
    public class CompanyService : BaseRepository<Company>, ICompanyService
    {
        public CompanyService(IRepository<Company> repository) : base(repository)
        {
        }
        public async Task<List<Company>> GetCompaniesWithCities()
        {
            var allCompanies = await QueryNoTracking().Include(c => c.City).ToListAsync();            
            return allCompanies;
        }
    }
}
