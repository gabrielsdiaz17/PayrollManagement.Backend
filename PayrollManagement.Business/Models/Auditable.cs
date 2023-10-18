using System.ComponentModel.DataAnnotations;

namespace PayrollManagement.Business.Models
{
    public class Auditable
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual long CreatedById { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual long? UpdatedById { get; set; }
        public virtual DateTime? LastModifiedDate { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
