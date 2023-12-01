using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollManagement.Business.Models
{
    public class CostCenter : Auditable
    {
        public string Name { get; set; }
        //[ForeignKey("User")]
        public long? UserId { get; set; }
        public User User { get; set; }
        public long CompanyId { get; set; }
        public Company Company { get; set; }
        public virtual IList<Worker> Workers { get; set; }
    }
}
