using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Business.ModuleWorker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleCostCenter.Models
{
    public class CostCenter: Auditable
    {
        public string Name { get; set; }
        public long UserId { get; set; }
        public User? User { get; set; }
        public virtual IList<Worker> Workers { get; set; }
    }
}
