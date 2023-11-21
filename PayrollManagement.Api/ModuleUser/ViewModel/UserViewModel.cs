using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleUser.ViewModel
{
    public class UserViewModel: Auditable
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public long RoleId { get; set; }
        public long? CostCenterId { get; set; }
        public long UserInfoId { get; set; }
        public long? CompanyId { get; set; }


    }
}
