using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleRegion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleCity.Models
{
    public class City : Auditable
    {
        public string Code3 { get; set; }
        public string Name { get; set; }
        public long RegionId { get; set; }
        public Region Region { get; set; }
    }
}
