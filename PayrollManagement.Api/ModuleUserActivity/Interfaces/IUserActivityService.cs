using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUserActivity.Interfaces
{
    public interface IUserActivityService:IRepository<UserActivity>
    {
    }
}
