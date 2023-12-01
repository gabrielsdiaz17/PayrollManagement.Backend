using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleRole.Interfaces
{
    public interface IRoleService: IRepository<Role>
    {
    }
}
