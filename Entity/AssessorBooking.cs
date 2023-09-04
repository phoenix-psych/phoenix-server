namespace Web.Entity
{
    public class AssessorBooking : BaseEntity
    {
        public Guid AssessorId { get; set; }
        public Guid IndividualId { get; set; }
        public DateTime Date { get; set;}
        public string Slot { get; set;}

    }
}
