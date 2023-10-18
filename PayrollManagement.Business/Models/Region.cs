using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.Models
{
    public class Region : Auditable
    {
        public string Name { get; set; }
        public string Code3 { get; set; }

    }
}
