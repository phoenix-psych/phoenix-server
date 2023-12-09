using Web.Entity;

namespace AIMSService.Entity
{
    public class TowreGradeEqui : BaseEntity
    {
        public decimal? Grade_equivalent { get; set; }
        public int? Sight_Word_Efficiency_raw_score_FROM { get; set; }
        public int? Sight_Word_Efficiency_raw_score_TO { get; set; }
        public int? Phonemic_Decoding_Efficiency_raw_score_FROM { get; set; }
        public int? Phonemic_Decoding_Efficiency_raw_score_TO { get; set; }
    }
}
