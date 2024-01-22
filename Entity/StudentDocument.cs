using Web.Entity;

namespace AIMSService.Entity
{
    public class StudentDocument : BaseEntity
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int RawNumber { get; set; }

    }
}
