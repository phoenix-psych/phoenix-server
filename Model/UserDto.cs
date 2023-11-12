using System.ComponentModel.DataAnnotations;
using Web.Helper.Enum;

namespace Web.Model
{
    public class UserDto
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime Dob { get; set; }

        public string Email { get; set; }

        public string Type { get; set; }

        public UserTypeEnum UserType { get; set; }

    }
}
