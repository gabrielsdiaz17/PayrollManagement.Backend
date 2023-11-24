using PayrollManagement.Business.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollManagement.Business.Models
{
    public class UserInfo : Auditable
    {
        [ForeignKey("User")]
        public long? UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public string IdentificationNumber { get; set; }
        public string UserEmail { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EntryDate { get; set; }
        public int PhoneNumber { get; set; }
        public Genre Genre { get; set; }
        public string Address { get; set; }
        public long CityId { get; set; }
        public City City { get; set; }

        //[ForeignKey("Worker")]
        public long? WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
