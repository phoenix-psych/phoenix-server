using System.ComponentModel.DataAnnotations;
using Web.Entity;
using Web.Helper.Enum;

namespace AIMSService.Entity
{
    public class ClientTOWREDetail : BaseEntity
    {
        public Guid ClientId { get; set; }

        public string? selected { get; set; }
        public string? sweRawScore { get; set; }
        public string? sweAgeEqui { get; set; }
        public string? sweGradeEqui { get; set; }
        public string? sweRank { get; set; }
        public string? sweScale { get; set; }
        public string? sweDesc { get; set; }
        public string? pdeRawScore { get; set; }
        public string? pdeAgeEqui { get; set; }
        public string? pdeGradeEqui { get; set; }
        public string? pdeRank { get; set; }
        public string? pdeScale { get; set; }
        public string? pdeDesc { get; set; }
        public string? pdeSum { get; set; }
        public string descriptiveTerm { get; set; }

        public string? towreScaleScore { get; set; }

    }
}
