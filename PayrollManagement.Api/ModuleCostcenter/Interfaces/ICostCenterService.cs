using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleCostcenter.Interfaces
{
    public interface ICostCenterService:IRepository<CostCenter>
    {
        Task<List<CostCenter>> GetCostCenterWithUser();

    }
}
