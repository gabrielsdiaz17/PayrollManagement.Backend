using Microsoft.EntityFrameworkCore;
using PayrollManagement.Api.ModuleUser.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.HelperModels;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUser.Services
{
    public class UserService : BaseRepository<User>, IUserService
    {
        public UserService(IRepository<User> repository) : base(repository)
        {

        }
        public async Task<User> GetUserLogin(UserLogin login)
        {
            var user = await QueryNoTracking().Where(us => us.Name == login.Name && us.Password == login.Password)
                .Include(us => us.UserInfo)
                .Include(us => us.CostCenter)
                .Include(us => us.Role)
                .FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<User>> GetUserWithUserInfo()
        {
            var usersWithUserInfo = await QueryNoTracking()
                .Include(us => us.UserInfo)
                .Include(us => us.CostCenter)
                .Include(us => us.Role)
                .ToListAsync();
            return usersWithUserInfo;
        }
    }
}
