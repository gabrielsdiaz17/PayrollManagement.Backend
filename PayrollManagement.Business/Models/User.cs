using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollManagement.Business.Models
{
    public class User : Auditable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }        
        public long? CostCenterId { get; set; }
        public CostCenter CostCenter { get; set; }

        public long? UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public virtual IList<UserActivity>? UserActivities { get; set; }
    }
}
