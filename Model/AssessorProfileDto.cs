namespace Web.Model
{
    public class AssessorProfileDto
    {
        public Guid? Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public string CurrentAddress { get; set; }
        public string Pin { get; set; }
        public string Pronoun { get; set; }
        public string ImageUrl { get; set; }

    }
}
