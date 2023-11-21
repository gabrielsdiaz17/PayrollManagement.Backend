using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUserInfo.Interface
{
    public interface IUserInfoService:IRepository<UserInfo>
    {
    }
}
