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
}
