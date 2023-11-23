using Microsoft.EntityFrameworkCore;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Contracts;
using PayrollManagement.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Repository
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Company>> GetCompaniesWithCities()
        {
            var allCompanies = await _dbContext.Company.Include(c=>c.City).ToListAsync();
            return allCompanies;
        }
    }
}
