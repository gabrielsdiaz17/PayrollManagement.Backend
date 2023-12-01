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
    }
}
