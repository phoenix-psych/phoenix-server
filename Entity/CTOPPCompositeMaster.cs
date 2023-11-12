namespace Web.Entity
{
    public class CTOPPCompositeMaster : BaseEntity
    {
        public int? CompositeScore { get; set; }
        public int? SumOf3 { get; set; }
        public int? SumOf2 { get; set; }
        public string PercentileRank { get; set; }
    }
}
