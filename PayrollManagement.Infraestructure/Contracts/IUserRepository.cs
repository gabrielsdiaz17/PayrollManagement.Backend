using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.HelperModels;
using PayrollManagement.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Contracts
{
    public interface IUserRepository: IRepository<User>
    {
        Task<List<User>> GetUserWithUserInfo();
        Task <User> GetUserLogin(UserLogin login);
    }
}
