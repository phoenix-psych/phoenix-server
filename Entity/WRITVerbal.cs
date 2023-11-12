namespace Web.Entity
{
    public class WRITVerbal : BaseEntity
    {
        public int SUM_OF_VERBAL_STD_SCORES_FROM { get; set; }
        public int SUM_OF_VERBAL_STD_SCORES_TO { get; set; }
        public decimal? IQ_SCORES_FROM { get; set; }
        public decimal? IQ_SCORES_TO { get; set; }
        public decimal? PERCENTILES_FROM { get; set; }
        public decimal? PERCENTILES_TO { get; set; }
        public decimal? CONFIDENCE_90_FROM { get; set; }
        public decimal? CONFIDENCE_90_TO { get; set; }
        public decimal? INTERVALS_95_FROM { get; set; }
        public decimal? INTERVALS_95_TO { get; set; }

    }
}
