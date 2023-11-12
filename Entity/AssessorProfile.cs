namespace Web.Entity
{
    public class AssessorProfile : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Dob { get; set; }
        public string CurrentAddress { get; set; }
        public string Pin { get; set; }
        public string Pronoun { get; set; }
        public string ImageUrl { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

    }
}
