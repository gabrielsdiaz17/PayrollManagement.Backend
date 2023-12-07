using Microsoft.EntityFrameworkCore;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Contracts;
using PayrollManagement.Infraestructure.Data;
using PayrollManagement.Infraestructure.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Repository
{
    public class UserActivityRepository : BaseRepository<UserActivity>, IUserActivityRepository
    {
        public UserActivityRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<UserActivity>> GetAcitivityByDates(UserActivityFilter filter)
        {
            var userActivityBetweenDates = await _dbContext.UserActivity
                .Where(ac => ac.DateActivity >= filter.StartDate && ac.DateActivity <= filter.EndDate)
                .Include(us => us.User)
                .Include(w => w.Worker)
                .ToListAsync();
            return userActivityBetweenDates;
        }

        public async Task<List<UserActivity>> GetActivityByDateAndUser(UserActivitityFilterWithUser activity)
        {
            var userActivityForUser = await _dbContext.UserActivity
                .Where(ac => ac.DateActivity >= activity.StartDate && ac.DateActivity <= activity.EndDate && ac.WorkerId == activity.UserId)
                .Include(us => us.User)
                .Include (w => w.Worker)
                .ToListAsync();
            return userActivityForUser;
        }
    }
}
