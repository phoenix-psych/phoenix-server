using System.ComponentModel.DataAnnotations;

namespace Web.Entity
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public Guid CreatedUser { get; set; }
        public Guid ModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
