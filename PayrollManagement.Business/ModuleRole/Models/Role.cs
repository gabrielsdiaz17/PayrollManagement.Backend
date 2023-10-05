using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleRole.Models
{
    public class Role:Auditable
    {       
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
