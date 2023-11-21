using Web.Entity;

namespace AIMSService.Entity
{
    public class ARTMaster : BaseEntity
    {
            public int? Centile { get; set; }
            public int? Standard_score_equivalent { get; set; }
            public int? Aloud_reading_accuracy { get; set; }
            public int? Aloud_reading_comprehension { get; set; }
            public int? Aloud_reading_rate { get; set; }
            public int? Silent_reading_comprehension { get; set; }
            public int? Silent_reading_rate { get; set; }
            public int? Writing_speed { get; set; }

    }
}
