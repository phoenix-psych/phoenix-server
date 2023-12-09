using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartFormBAccuracy : BaseEntity
    {
        public int? age_year_from { get; set; }
        public int? age_month_from { get; set; }
        public int? age_year_to { get; set; }
        public int? age_month_to { get; set; }
        public int? percentile_Rank { get; set; }
        public int? Accuracy_from { get; set; }
        public int? Accuracy_to { get; set; }
        public int? scaled_score { get; set; }
    }
}
