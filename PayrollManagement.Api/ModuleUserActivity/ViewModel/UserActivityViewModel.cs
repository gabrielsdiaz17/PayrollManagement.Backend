using PayrollManagement.Api.ModuleUser.ViewModel;
using PayrollManagement.Api.ModuleWorker.ViewModels;
using PayrollManagement.Business.Enums;
using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleUserActivity.ViewModel
{
    public class UserActivityViewModel:Auditable
    {
        public long UserId { get; set; }
        public long WorkerId { get; set; }
        public DateTime DateActivity { get; set; }
        public TypeActivity TypeActivity { get; set; }
        public string Observation { get; set; }

    }
    public class UserActivityViewModelDetails: UserActivityViewModel
    {
        public UserViewModel User { get; set; }
        public WorkerViewModel Worker { get; set; }
    }
}
