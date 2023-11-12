namespace Web.Entity
{
    public class Answers : BaseEntity
    {
        public Guid IndividualId { get; set; }
        public Guid QuestionId { get; set; }
        public string Answer { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
        public virtual Questions Question { get; set; }

    }
}
