using Web.Entity;

namespace AIMSService.Entity
{
    public class WRAT_Blue : BaseEntity
    {
        public int? year_from { get; set; }
        public int? month_from { get; set; }
        public int? year_to { get; set; }
        public int? month_to { get; set; }
        public int? Standard_score { get; set; }
        public int? Word_Reading_FROM { get; set; }
        public int? Word_Reading_TO { get; set; }
        public int? Spelling_FROM { get; set; }
        public int? SpellingTO { get; set; }
        public int? Math_Computation_FROM { get; set; }
        public int? Math_Computation_TO { get; set; }
        public int? Reading_Composite_FROM { get; set; }
        public int? Reading_Composite_TO { get; set; }
        public int? Sentence_Comprehension_FROM { get; set; }
        public int? Sentence_ComprehensionTO { get; set; }

    }
}
