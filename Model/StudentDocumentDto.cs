namespace AIMSService.Model
{
    public class StudentDocumentDto 
    {
        public string Id { get; set; }
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int RawNumber { get; set; }
    }
}
