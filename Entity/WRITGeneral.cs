namespace Web.Entity
{
    public class WRITGeneral : BaseEntity
    {
        public int SUM_OF_ALL_SUBTEST_STD_SCORE_FROM { get; set; }
        public int SUM_OF_ALL_SUBTEST_STD_SCORE_TO { get; set; }
        public decimal? IQ_SCORES_FROM { get; set; }
        public decimal? IQ_SCORE_TO { get; set; }
        public decimal? PERCENTILES_FROM { get; set; }
        public decimal? PERCENTILES_TO { get; set; }
        public decimal? CONFIDENCE_INETRVAL_90_FROM { get; set; }
        public decimal? CONFIDENCE_INETRVAL_90_TO { get; set; }
        public decimal? CONFIDENCE_INETRVAL_95_FROM { get; set; }
        public decimal? CONFIDENCE_INETRVAL_95_TO { get; set; }
    }
}
