using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartFormAAccuracy : BaseEntity
    {
        public int? year_from { get; set; }
        public int? month_from { get; set; }
        public int? year_to { get; set; }
        public int? month_to { get; set; }
        public int? ile_Rank { get; set; }
        public int? scaled_score { get; set; }
        public int? Accuracy_from { get; set; }
        public int? Accuracy_to { get; set; }
    }
}
