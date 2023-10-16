using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Business.ModuleWorker.Models;
using PayrollManagement.Business.ModuleWorker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleCostCenter.ViewModels
{
    public class CostCenterViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public virtual IList<Worker> Workers { get; set; }
    }
}
