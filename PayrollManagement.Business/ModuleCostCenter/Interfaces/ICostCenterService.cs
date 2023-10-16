using PayrollManagement.Business.ModuleCostCenter.Models;
using PayrollManagement.Infraestructure.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement.Business.ModuleCostCenter.Interfaces
{
    public interface ICostCenterService : IRepository<CostCenter>
    {
    }
}
