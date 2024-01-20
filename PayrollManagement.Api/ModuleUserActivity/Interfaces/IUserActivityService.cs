using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.HelperModels;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUserActivity.Interfaces
{
    public interface IUserActivityService:IRepository<UserActivity>
    {
        Task<List<UserActivity>> GetAcitivityByDates(UserActivityFilter filter);
        Task<List<UserActivity>> GetActivityByDateAndUser(UserActivitityFilterWithUser activity);
    }
}
