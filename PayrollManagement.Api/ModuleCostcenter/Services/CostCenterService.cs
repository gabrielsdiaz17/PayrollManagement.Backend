using Microsoft.EntityFrameworkCore;
using PayrollManagement.Api.ModuleCostcenter.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleCostcenter.Services
{
    public class CostCenterService : BaseRepository<CostCenter>, ICostCenterService
    {
        public CostCenterService(IRepository<CostCenter> repository) : base(repository)
        {
        }
        public async Task<List<CostCenter>> GetCostCenterWithUser()
        {
            var costCenterWithUser = await QueryNoTracking().Include(u => u.User).ToListAsync();
            return costCenterWithUser;
        }
    }
}
