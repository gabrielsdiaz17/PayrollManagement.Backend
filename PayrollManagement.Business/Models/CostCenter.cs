namespace PayrollManagement.Business.Models
{
    public class CostCenter : Auditable
    {
        public string Name { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public virtual IList<Worker> Workers { get; set; }
    }
}
