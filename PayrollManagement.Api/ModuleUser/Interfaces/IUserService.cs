using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUser.Interfaces
{
    public interface IUserService: IRepository<User>
    {
    }
}
