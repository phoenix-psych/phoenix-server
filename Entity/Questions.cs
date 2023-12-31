﻿using Web.Helper.Enum;

namespace Web.Entity
{
    public class Questions : BaseEntity
    {
        public QuestionTypeEnum Type { get; set; }
        public QuestionGroupEnum Group { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Option5 { get; set; }
        public string Option6 { get; set; }
        public string Option7 { get; set; }

        public virtual ICollection<Answers> Answers { get; set; }

    }
}
