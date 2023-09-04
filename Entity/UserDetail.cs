using System.ComponentModel.DataAnnotations;
using Web.Helper.Enum;

namespace Web.Entity
{
    public class UserDetail : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string CorporateId { get; set; }
        public string Email { get; set; }
        public UserTypeEnum UserType { get; set; }

        public virtual User User { get; set; }
    }
}
