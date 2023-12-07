using PayrollManagement.Api.ModuleCostcenter.ViewModel;
using PayrollManagement.Api.ModuleUserInfo.Services;
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
    public class UserQueryViewModel: UserViewModel
    {
        public UserInfoViewModel UserInfo { get; set; }
        public CostCenterViewModel CostCenter { get; set; }
    }
    public class UserLoginViewModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
