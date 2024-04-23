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

        public string? Address { get; set; }
        public string? University { get; set; }
        public string? Course { get; set; }
        public string? CourseYear { get; set; }

        public string? UserName { get; set; }
        public string? Passwod { get; set; }

        public int? Gender { get; set; }

        public Guid? UserId { get; set; }
        public Guid? AsssessorId { get; set; }

    }
}
