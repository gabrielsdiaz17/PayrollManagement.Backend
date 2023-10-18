using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollManagement.Business.Models
{
    public class User : Auditable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public Role Role { get; set; }

        [ForeignKey("CostCenter")]
        public long? CostCenterId { get; set; }
        public CostCenter CostCenter { get; set; }

        [ForeignKey("UserInfo")]
        public long UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public virtual IList<UserActivity>? UserActivities { get; set; }
    }
}
