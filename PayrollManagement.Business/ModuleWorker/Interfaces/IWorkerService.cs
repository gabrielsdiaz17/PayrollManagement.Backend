using PayrollManagement.Business.ModuleWorker.Models;
using PayrollManagement.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleWorker.Interfaces
{
    public interface IWorkerService:IRepository<Worker>
    {
    }
}
