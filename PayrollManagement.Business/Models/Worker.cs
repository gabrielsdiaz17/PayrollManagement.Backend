using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.Models
{
    public class Worker : Auditable
    {
        public long CostCenterId { get; set; }
        public CostCenter CostCenter { get; set; }
        public long UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public virtual IList<UserActivity> UserActivities { get; set; }
    }
}
