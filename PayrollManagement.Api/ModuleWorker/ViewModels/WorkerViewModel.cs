using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleWorker.ViewModels
{
    public class WorkerViewModel : Auditable
    {
        public long CostCenterId { get; set; }
        public long UserInfoId { get; set; }
        public long CompanyId { get; set; }

    }
    public class WorkerQueryViewModel:WorkerViewModel
    {
        public UserInfo UserInfo { get; set; }
    }
}
