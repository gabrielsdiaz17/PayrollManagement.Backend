using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleCompany.Interfaces
{
    public interface ICompanyService:IRepository<Company>
    {
    }
}
