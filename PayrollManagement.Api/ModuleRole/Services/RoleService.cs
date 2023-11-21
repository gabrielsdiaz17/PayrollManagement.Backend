using PayrollManagement.Api.ModuleRole.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleRole.Services
{
    public class RoleService : BaseRepository<Role>, IRoleService
    {
        public RoleService(IRepository<Role> repository) : base(repository)
        {
        }
    }
}
