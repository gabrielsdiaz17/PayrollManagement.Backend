using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.HelperModels;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUser.Interfaces
{
    public interface IUserService: IRepository<User>
    {
        Task<List<User>> GetUserWithUserInfo();
        Task<User> GetUserLogin(UserLogin login);
    }
}
