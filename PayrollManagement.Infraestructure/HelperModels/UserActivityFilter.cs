using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.HelperModels
{
    public class UserActivityFilter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class UserActivitityFilterWithUser: UserActivityFilter 
    {
        public long UserId { get; set; }
    }
}
