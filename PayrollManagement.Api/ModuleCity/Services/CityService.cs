using PayrollManagement.Api.ModuleCity.Interfaces;
using PayrollManagement.Business.Models;
using PayrollManagement.Infraestructure.Repository;

namespace PayrollManagement.Api.ModuleCity.Services
{
    public class CityService : BaseRepository<City>, ICityService
    {
        public CityService(IRepository<City> repository) : base(repository)
        {
        }
    }
}
