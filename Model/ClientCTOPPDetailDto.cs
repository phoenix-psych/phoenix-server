namespace AIMSService.Model
{
    public class ClientCTOPPDetailDto
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }

        public int? ElRawScore { get; set; }
        public int? ElScaleScore { get; set; }
        public string? ElPercentageRank { get; set; }

        public int? BwRawScore { get; set; }
        public int? BwScaleScore { get; set; }
        public string? BwPercentageRank { get; set; }

        public int? PlRawScore { get; set; }
        public int? PlScaleScore { get; set; }
        public string? PlPercentageRank { get; set; }

        public int? MdRawScore { get; set; }
        public int? MdScaleScore { get; set; }
        public string? MdPercentageRank { get; set; }

        public int? NrRawScore { get; set; }
        public int? NrScaleScore { get; set; }
        public string? NrPercentageRank { get; set; }

        public int? RdRawScore { get; set; }
        public int? RdScaleScore { get; set; }
        public string? RdPercentageRank { get; set; }

        public int? RlRawScore { get; set; }
        public int? RlScaleScore { get; set; }
        public string? RlPercentageRank { get; set; }

        public int? BnRawScore { get; set; }
        public int? BnScaleScore { get; set; }
        public string? BnPercentageRank { get; set; }

        public int? snRawScore { get; set; }
        public int? snScaleScore { get; set; }
        public string? snPercentageRank { get; set; }

        public string? selected { get; set; }

        public int? PaSum { get; set; }
        public int? PmSum { get; set; }
        public int? RsnSum { get; set; }
        public int? apaSum { get; set; }

        public int? PAScore { get; set; }
        public string? PACI { get; set; }
        public string? PADesc { get; set; }
        public string? PARank { get; set; }

        public int? PMScore { get; set; }
        public string? PMCI { get; set; }
        public string? PMDesc { get; set; }
        public string? PMRank { get; set; }

        public int? RSNScore { get; set; }
        public string? RSNCI { get; set; }
        public string? RSNDesc { get; set; }
        public string? RSNRank { get; set; }

        public int? APAScore { get; set; }
        public string? APACI { get; set; }
        public string? APADesc { get; set; }
        public string? APARank { get; set; }

    }
}
