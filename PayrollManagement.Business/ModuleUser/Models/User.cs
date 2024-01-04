using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Business.ModuleRole.Models;
using PayrollManagement.Business.ModuleUserActivity.Models;
using PayrollManagement.Business.ModuleUserInfo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollManagement.Business.ModuleUser.Models
{
    public class User : IdentityUser<long>
    {
     
        public virtual long CreatedById { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual long? UpdatedById { get; set; }
        public virtual DateTime? LastModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsActive { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Token { get; set; }
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
