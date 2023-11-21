using PayrollManagement.Api.ModuleUser.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUser.Services
{
    public class UserService : BaseRepository<User>, IUserService
    {
        public UserService(IRepository<User> repository) : base(repository)
        {
        }
    }
}
