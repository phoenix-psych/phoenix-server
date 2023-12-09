using System;
using Web.Entity;

namespace AIMSService.Entity
{
    public class GoartFormAComprehension : BaseEntity
    {
        public int? Age_year_from { get; set; }
        public int? Age_month_from { get; set; }
        public int? Age_year_to { get; set; }
        public int? Age_month_to { get; set; }
        public int? PercentileRank { get; set; }
        public int? Comprehension_from { get; set; }
        public int? Comprehension_to { get; set; }
        public int? scaled_score {get;set;}
}
}
