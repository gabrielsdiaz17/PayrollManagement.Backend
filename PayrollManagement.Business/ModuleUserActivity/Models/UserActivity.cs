using PayrollManagement.Business.ModuleAuditable.Models;
using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Business.ModuleUserActivity.Enums;
using PayrollManagement.Business.ModuleWorker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleUserActivity.Models
{
    public class UserActivity: Auditable
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long WorkerId { get; set; }
        public Worker Worker { get; set; }
        public DateTime DateActivity { get; set; }
        public TypeActivity TypeActivity { get; set; }
        public string Observation { get; set; }
    }
}
