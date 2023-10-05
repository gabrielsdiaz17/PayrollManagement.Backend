using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleCity.Models;
using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Business.ModuleWorker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleCompany.Models
{
    public class Company:Auditable
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public virtual IList<User> Users { get; set; }
        public virtual IList<CostCenter> CostCenters { get; set; }
        public virtual IList<Worker> Workers { get; set; }
        public long CityId { get; set; }
        public City City { get; set; }

    }
}
