using PayrollManagement.Business.ModuleWorker.Interfaces;
using PayrollManagement.Business.ModuleWorker.Models;
using PayrollManagement.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleWorker.Services
{
    public class WorkerService: BaseRepository<Worker>, IWorkerService
    {
        public WorkerService(IRepository<Worker> repository) : base(repository) 
        { 
        }
    }
}
