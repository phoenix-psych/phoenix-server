using Web.Helper.Enum;

namespace Web.Entity
{
    public class AssessorSlot : BaseEntity
    {
        public Guid AssessorId { get; set; }
        public Guid SlotId { get; set; }
        public SlotAvailableEnum Availability { get; set; }

    }
}
