using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartFormAFluency : BaseEntity
    {
        public int? age_year_from { get; set; }
        public int? age_month_from { get; set; }
        public int? age_year_to { get; set; }
        public int? age_month_to { get; set; }
        public int? ile_Rank { get; set; }
        public int? scaled_score { get; set; }
        public int? Fluency_from { get; set; }
        public int? Fluency_to { get; set; }
    }
}
