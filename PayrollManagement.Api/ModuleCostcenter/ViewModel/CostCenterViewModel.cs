using PayrollManagement.Api.ModuleUser.ViewModel;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleCostcenter.ViewModel
{
    public class CostCenterViewModel: Auditable
    {
        public string Name { get; set; }
        public long UserId { get; set; }
        public long CompanyId { get; set; }
    }
    public class  CostCenterQueryViewModel: CostCenterViewModel
    {
        public UserViewModel User { get; set; }
    }
}
