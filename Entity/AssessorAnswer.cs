using Web.Helper.Enum;

namespace Web.Entity
{
    public class AssessorAnswer : BaseEntity
    {
        public Guid UserId { get; set; } = Guid.Empty;
        public Guid QustionId { get; set; } = Guid.Empty;

        public int Page { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
    }
}
