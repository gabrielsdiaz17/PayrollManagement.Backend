using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.HelperModels;
using PayrollManagement.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Contracts
{
    public interface IUserActivityRepository: IRepository<UserActivity>
    {
        Task <List<UserActivity>> GetAcitivityByDates(UserActivityFilter filter);
        Task <List<UserActivity>> GetActivityByDateAndUser(UserActivitityFilterWithUser activity);
    }
}
