namespace Web.Entity
{
    public class WRITVisual : BaseEntity
    {
        public int SUM_OF_VISUAL_STD_SCORES_FROM { get; set; }
        public int SUM_OF_VISUAL_STD_SCORES_TO { get; set; }
        public decimal? IQ_SCORES_FREOM { get; set; }
        public decimal? IQ_SCORES_TO { get; set; }
        public decimal? PERCENTILES_FROM { get; set; }
        public decimal? PERCENTILES_TO { get; set; }
        public decimal? CONFIDENCE_INTERVALS90_FROM { get; set; }
        public decimal? CONFIDENCE_INTERVALS90_TO { get; set; }
        public decimal? CONFIDENCE_INTERVAL_95_FROM { get; set; }
        public decimal? CONFIDENCE_INTERVAL_95_TO { get; set; }

    }
}
