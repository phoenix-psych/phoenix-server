namespace AIMSService.Model
{
    public class WRATScoreDto
    {
        public int? RawScore { get; set; }
        public int? StandardScore { get; set; }
        public string? ConfidenceInterval { get; set; }
        public string? Percentage { get; set; }
        public string? Grade { get; set; }
    }
}
