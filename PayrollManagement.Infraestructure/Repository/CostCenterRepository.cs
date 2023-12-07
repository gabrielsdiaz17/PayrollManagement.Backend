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
    public class CostCenterRepository : BaseRepository<CostCenter>, ICostCenterRepository
    {
        public CostCenterRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<CostCenter>> GetCostCenterWithUser()
        {
            var costCenterWithUser = await _dbContext.CostCenter.Include(u=> u.User).ToListAsync();
            return costCenterWithUser;
        }
    }
}
