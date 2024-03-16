namespace AIMSService.Model
{
    public class AssessorSummaryDto
    {
        public string? Clients { get; set; }
        public string? CompletedScreeners { get; set; }
        public string? Tests { get; set; }
        public string? TestFinished { get; set; }
        public string? ReportPending { get; set; }
        public string? ReportCompleted { get; set; }
        public string? PaymentPending { get; set; }
    }
}
