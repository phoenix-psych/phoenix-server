namespace Web.Model
{
    public class NgFormFieldDto
    {
        public string ControlType { get; set; }
        public string? Key { get; set; }
        public string? Label { get; set; }
        public string? Text { get; set; }
        public bool? Required { get; set; }
        public int Order { get; set; }
        public List<NgOptionDto>? Options { get; set; }
    }
}
