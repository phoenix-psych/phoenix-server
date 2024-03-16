using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web.Helper.Enum;

namespace Web.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public bool IsAdmin { get; set; } = false;

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Email { get; set; }

        public UserTypeEnum UserType { get; set; }

        public virtual AssessorProfile AssessorProfile { get; set; }

    }
}
