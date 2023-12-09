using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartRank : BaseEntity
    {
        public int? Percentile_rank { get; set; }
        public int? Sum_of_scaled_scores_Fluency_Comprehension { get; set; }
        public int? Oral_Reading_Index { get; set; }

    }
}
