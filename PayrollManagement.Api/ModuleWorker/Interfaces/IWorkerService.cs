using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleWorker.Interfaces
{
    public interface IWorkerService: IRepository<Worker>
    {
        Task<List<Worker>> GetWorkerWithUserInfo();
        Task<List<Worker>> GetUserActivityByWorker(long workerId);
    }
}
