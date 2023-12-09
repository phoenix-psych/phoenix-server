using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartFormBRate : BaseEntity
    {
        public int age_year_from { get; set; }
        public int age_month_from { get; set; }
        public int age_year_to { get; set; }
        public int age_month_to { get; set; }
        public string percentile_Rank { get; set; }
        public int scaled_score { get; set; }
        public int rate_from { get; set; }
        public int rate_to { get; set; }
    }
}
