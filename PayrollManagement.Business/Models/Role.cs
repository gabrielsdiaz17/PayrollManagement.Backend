using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.Models
{
    public class Role : Auditable
    {
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
