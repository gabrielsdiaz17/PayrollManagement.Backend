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
    }
}
