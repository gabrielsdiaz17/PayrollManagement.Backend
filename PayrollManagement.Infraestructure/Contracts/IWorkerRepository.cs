using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Infraestructure.Contracts
{
    public interface IWorkerRepository: IRepository<Worker>
    {
        Task<List<Worker>> GetWorkerWithUserInfo();
        Task<List<Worker>> GetUserActivityByWorker(long workerId);
    }
}
