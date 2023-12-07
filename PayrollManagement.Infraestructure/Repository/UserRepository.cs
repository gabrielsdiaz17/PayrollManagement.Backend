using Microsoft.EntityFrameworkCore;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Contracts;
using PayrollManagement.Infraestructure.Data;
using PayrollManagement.Infraestructure.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<User> GetUserLogin(UserLogin login)
        {
            var user = await _dbContext.User.Where(us=> us.Name == login.Name && us.Password == login.Password)
                .FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<User>> GetUserWithUserInfo()
        {
            var usersWithUserInfo = await _dbContext.User
                .Include(us => us.UserInfo)
                .Include(us=>us.CostCenter)
                .ToListAsync();
            return usersWithUserInfo;
        }
    }
}
