using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.Models
{
    public class Worker : Auditable
    {
        public long? CostCenterId { get; set; }
        public CostCenter CostCenter { get; set; }
        [ForeignKey("UserInfo")]

        public long? UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public virtual IList<UserActivity> UserActivities { get; set; }
    }
}
