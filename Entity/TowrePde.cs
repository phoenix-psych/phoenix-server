using Web.Entity;

namespace AIMSService.Entity
{
    public class TowrePde : BaseEntity
    {
        public int? AgeFromYear { get; set; }
        public int? AgeToYear { get; set; }
        public int? AgeFromMonth { get; set; }
        public int? AgeToMonth { get; set; }
        public int? Raw_score { get; set; }
        public int? Score { get; set; }
    }
}
