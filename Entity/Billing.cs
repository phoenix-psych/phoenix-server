namespace Web.Entity
{
    public class Billing : BaseEntity
    {
        public Guid IndividualId { get; set; }
        public decimal IndividualContribution { get; set; }
        public decimal UniversityContribution { get; set; }

    }
}
