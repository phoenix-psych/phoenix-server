namespace AIMSService.Model
{
    public class ClientWRATDetailDto
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }

        public string? selected { get; set; }
        public string? wrRawScore { get; set; }
        public int? wrStandardScore { get; set; }
        public string? wrCI { get; set; }
        public string? wrPer { get; set; }
        public string? wrGrade { get; set; }
        public string? spRawScore { get; set; }
        public int? spStandardScore { get; set; }
        public string? spCI { get; set; }
        public string? spPer { get; set; }
        public string? spGrade { get; set; }
        public string? mcRawScore { get; set; }
        public int? mcStandardScore { get; set; }
        public string? mcCI { get; set; }
        public string? mcPer { get; set; }
        public string? mcGrade { get; set; }
        public string? scRawScore { get; set; }
        public int? scStandardScore { get; set; }
        public string? scCI { get; set; }
        public string? scPer { get; set; }
        public string? scGrade { get; set; }
        public string? rcRawScore { get; set; }
        public int? rcStandardScore { get; set; }
        public string? rcCI { get; set; }
        public string? rcPer { get; set; }
        public string? rcGrade { get; set; }

    }
}
