using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleUserActivity.ViewModel
{
    public class UserActivityViewModel:Auditable
    {
        public long UserId { get; set; }
        public long WorkerId { get; set; }
        public string Observation { get; set; }
        public DateTime DateActivity { get; set; }
    }
}
