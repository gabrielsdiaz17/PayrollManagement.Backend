using PayrollManagement.Api.ModuleRegion.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleRegion.Services
{
    public class RegionService : BaseRepository<Region>, IRegionService
    {
        public RegionService(IRepository<Region> repository) : base(repository)
        {
        }
    }
}
