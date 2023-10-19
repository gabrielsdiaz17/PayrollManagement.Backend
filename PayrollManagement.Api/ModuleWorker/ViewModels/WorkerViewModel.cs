using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleWorker.ViewModels
{
    public class WorkerViewModel
    {
        public long Id { get; set; }
        public long CostCenterId { get; set; }
        public CostCenter CostCenter { get; set; }
        public long UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public virtual IList<UserActivity> UserActivities { get; set; }
    }
}
