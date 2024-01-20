using PayrollManagement.Api.ModuleCostcenter.ViewModel;
using PayrollManagement.Api.ModuleUserActivity.ViewModel;
using PayrollManagement.Api.ModuleUserInfo.Services;
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
        public UserInfoViewModel UserInfo { get; set; }
        public CostCenterViewModel CostCenter { get; set; }
    }
    public class WorkerQueryUserActivity: WorkerViewModel
    {
        public virtual List<UserActivityViewModel> UserActivities { get; set; }
    }

}
