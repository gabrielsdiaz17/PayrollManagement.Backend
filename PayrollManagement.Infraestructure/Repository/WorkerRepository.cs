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
    public class WorkerRepository : BaseRepository<Worker>, IWorkerRepository
    {
        public WorkerRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Worker>> GetUserActivityByWorker(long wokerId)
        {
            var userActivityByWorker = await _dbContext.Worker.Where(w=> w.Id == wokerId)
                .Include(u=> u.UserActivities).ToListAsync();
            return userActivityByWorker;
        }

        public async Task<List<Worker>> GetWorkerWithUserInfo()
        {
            var workersWithUserInfo = await _dbContext.Worker.Include(u =>u.UserInfo)
                .Include(u=> u.CostCenter)
                .ToListAsync();
            return workersWithUserInfo;
        }
    }
}
