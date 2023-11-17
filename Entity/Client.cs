using System.ComponentModel.DataAnnotations;
using Web.Entity;
using Web.Helper.Enum;

namespace AIMSService.Entity
{
    public class Client : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Dob { get; set; }
        public ClientStatusEnum Status { get; set; }

    }
}
