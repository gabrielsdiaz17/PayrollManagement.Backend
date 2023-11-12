using PayrollManagement.Api.ModuleUserActivity.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleUserActivity.Services
{
    public class UserActivityService : BaseRepository<UserActivity>, IUserActivityService
    {
        public UserActivityService(IRepository<UserActivity> repository) : base(repository)
        {
        }
    }
    
}
