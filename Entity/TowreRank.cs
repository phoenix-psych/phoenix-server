using Web.Entity;

namespace AIMSService.Entity
{
    public class TowreRank : BaseEntity
    {
        public int? Index { get; set; }
        public int? Percentile_rank_FROM { get; set; }
        public int? Percentile_rank_TO { get; set; }
    }
}
