namespace Web.Entity
{
    public class CTOPPDescriptiveTerm : BaseEntity
    {
        public int? ScaledScoreTo { get; set; }
        public int? ScaledScoreFrom { get; set; }
        public string? DescriptiveTerm { get; set; }
        public int? CompositeScoreTo { get; set; }
        public int? CompositeScoreFrom { get; set; }

    }
}
