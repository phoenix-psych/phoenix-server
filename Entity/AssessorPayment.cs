namespace Web.Entity
{
    public class AssessorPayment : BaseEntity
    {
        public Guid AssessorId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public decimal Payment { get; set; }


    }
}
