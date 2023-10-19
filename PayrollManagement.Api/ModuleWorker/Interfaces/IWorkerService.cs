using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleWorker.Interfaces
{
    public interface IWorkerService: IRepository<Worker>
    {
    }
}
