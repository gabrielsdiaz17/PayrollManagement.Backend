using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Business.ModuleRole.Models;
using PayrollManagement.Business.ModuleUserActivity.Models;
using PayrollManagement.Business.ModuleUserInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleUser.Models
{
    public class User: Auditable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }
        public long CostCenterId { get; set; }
        public CostCenter CostCenter { get; set; }
        public long UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public virtual IList<UserActivity>? UserActivities { get; set; }
    }
}
