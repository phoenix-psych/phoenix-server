using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartFormAAgeEqui : BaseEntity
    {
        public decimal? Age_equiv { get; set; }
        public int? Rate_FROM { get; set; }
        public int? Rate_TO { get; set; }
        public int? Accuracy_FROM { get; set; }
        public int? Accuracy_TO { get; set; }
        public int? Fluency_FROM { get; set; }
        public int? Fluency_TO { get; set; }
        public int? Comprehension_FROM { get; set; }
        public int? Comprehension_TO { get; set; }
    }
}
