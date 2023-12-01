using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleCity.ViewModel
{
    public class CityViewModel: Auditable
    {
        public string Code3 { get; set; }
        public string Name { get; set; }
        public long RegionId { get; set; }
    }
}
