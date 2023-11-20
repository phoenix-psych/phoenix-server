using System.ComponentModel.DataAnnotations;
using Web.Entity;
using Web.Helper.Enum;

namespace AIMSService.Entity
{
    public class ClientDASHDetail : BaseEntity
    {
        public Guid ClientId { get; set; }

        public int? ElRawScore { get; set; }
        public int? BwRawScore { get; set; }
        public int? PlRawScore { get; set; }
        public int? MdRawScore { get; set; }
        public int? NrRawScore { get; set; }
        public int? RdRawScore { get; set; }
        public int? RlRawScore { get; set; }
        public int? BnRawScore { get; set; }
        public int? SnRawScore { get; set; }

        public int? CI { get; set; }

        public string? Description { get; set; }
    }
}
