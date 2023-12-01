using PayrollManagement.Api.ModuleWorker.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleWorker.Services
{
    public class WorkerService : BaseRepository<Worker>, IWorkerService
    {
        public WorkerService(IRepository<Worker> repository) : base(repository)
        {
        }
    }
}
