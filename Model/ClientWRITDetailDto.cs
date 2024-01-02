namespace AIMSService.Model
{
    public class ClientWRITDetailDto
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }

        public string? selected { get; set; }
        public string? vaRawScore { get; set; }
        public string? vaStandardScore { get; set; }
        public string? vaPercentile { get; set; }
        public string? vcRawScore { get; set; }
        public string? vcStandardScore { get; set; }
        public string? vcPercentile { get; set; }
        public string? vaSum { get; set; }
        public string? maRawScore { get; set; }
        public string? maStandardScore { get; set; }
        public string? maPercentile { get; set; }
        public string? diRawScore { get; set; }
        public string? diStandardScore { get; set; }
        public string? diPercentile { get; set; }
        public string? dSum { get; set; }
        public string? vbSumScore { get; set; }
        public string? vbIQ { get; set; }
        public string? vbPer { get; set; }
        public string? vbCI { get; set; }
        public string? viSumScore { get; set; }
        public string? viIQ { get; set; }
        public string? viPer { get; set; }
        public string? viCI { get; set; }
        public string? iqSumScore { get; set; }
        public string? iqIQ { get; set; }
        public string? iqPer { get; set; }
        public string? iqCI { get; set; }

    }
}
