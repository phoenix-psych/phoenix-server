namespace Web.Entity
{
    public class WRITSubtest : BaseEntity
    {
        public int AGE_YEAR_FROM { get; set; }
        public int AGE_MONTH_FROM { get; set; }
        public int AGE_YEAR_TO { get; set; }
        public int AGE_MONTH_TO { get; set; }
        public decimal? Raw_Scores { get; set; }
        public decimal? Matrices_Standard_Scores { get; set; }
        public decimal? Verbal_Analogies_Std_Scores { get; set; }
        public decimal? Diamonds_Standard_scores { get; set; }
        public decimal? Vocabulary_Standard_Scores { get; set; }

    }
}
