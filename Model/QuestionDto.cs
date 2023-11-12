using AutoMapper.Configuration.Annotations;
using System.ComponentModel.DataAnnotations;
using Web.Helper.Enum;

namespace Web.Model
{
    public class QuestionDto
    {
        [Ignore]
        public QuestionTypeEnum Type { get; set; }

        [Ignore]
        public QuestionGroupEnum Group { get; set; }

        public string QuestionType { get; set; }
        public string QuestionGroup { get; set; }
        public string Question { get; set; }
        
        public string Option1 { get; set; } = string.Empty;
        public string Option2 { get; set; } = string.Empty;
        public string Option3 { get; set; } = string.Empty;
        public string Option4 { get; set; } = string.Empty;
        public string Option5 { get; set; } = string.Empty;
        public string Option6 { get; set; } = string.Empty;
        public string Option7 { get; set; } = string.Empty;

    }
}
