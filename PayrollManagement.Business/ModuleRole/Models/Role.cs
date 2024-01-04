using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleUser.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleRole.Models
{
    public class Role: IdentityRole<long>
    { 
        public virtual long CreatedById { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual long? UpdatedById { get; set; }
        public virtual DateTime? LastModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsActive { get; set; }
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }        
       
    }
}
