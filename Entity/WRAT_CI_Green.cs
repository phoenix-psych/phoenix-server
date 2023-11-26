using Web.Entity;

namespace AIMSService.Entity
{
    public class WRAT_CI_Green : BaseEntity
    {
        public int? AgeFromYear { get; set; }
        public int? AgeToYear { get; set; }
        public int? AgeFromMonth { get; set; }
        public int? AgeToMonth { get; set; }
        public int? Word_Reading { get; set; }
        public int? Spelling { get; set; }
        public int? Math_Computation { get; set; }
        public int? Sentence_Comprehension { get; set; }
        public int? Reading_Composite { get; set; }

    }
}
