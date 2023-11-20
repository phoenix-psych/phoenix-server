using System.ComponentModel.DataAnnotations;
using Web.Entity;
using Web.Helper.Enum;

namespace AIMSService.Entity
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public ClientStatusEnum? Status { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? Service { get; set; }


        //public Guid? UserId { get; set; }
        //public Guid? ReportingTo { get; set; }

    }
}
