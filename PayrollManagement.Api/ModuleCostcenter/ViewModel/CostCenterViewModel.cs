using PayrollManagement.Business.Models;

namespace PayrollManagement.Api.ModuleCostcenter.ViewModel
{
    public class CostCenterViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        //public virtual IList<Worker> Workers { get; set; }
    }
}
