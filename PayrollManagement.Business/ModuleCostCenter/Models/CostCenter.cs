using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Business.ModuleWorker.Models;

namespace PayrollManagement.Business.ModuleCostCenter.Models
{
    public class CostCenter: Auditable
    {
        public string Name { get; set; } 
        public long UserId { get; set; }
        public User User { get; set; }
        public virtual IList<Worker> Workers { get; set; }
    }
}
