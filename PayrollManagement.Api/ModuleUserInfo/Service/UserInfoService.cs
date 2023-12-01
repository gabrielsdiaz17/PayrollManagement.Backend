using PayrollManagement.Api.ModuleUserInfo.Interface;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUserInfo.Service
{
    public class UserInfoService : BaseRepository<UserInfo>, IUserInfoService
    {
        public UserInfoService(IRepository<UserInfo> repository) : base(repository)
        {
        }
    }
}
