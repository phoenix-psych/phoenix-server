using System.ComponentModel.DataAnnotations;
using Web.Entity;
using Web.Helper.Enum;

namespace AIMSService.Entity
{
    public class ClientARTDetail : BaseEntity
    {
        public Guid ClientId { get; set; }

        public int? Accuracy { get; set; }
        public int? CoprehensionAloud { get; set; }
        public int? SpeedOfReadingAloud { get; set; }
        public int? CoprehensionSilent { get; set; }
        public int? SpeedOfReadingSilent { get; set; }
        public int? WritingSpeed { get; set; }

        public int? CI { get; set; }

        public string? Description { get; set; }
    }
}
