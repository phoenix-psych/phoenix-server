using Web.Helper.Enum;

namespace Web.Entity
{
    public class QuestionType : BaseEntity
    {
        public QuestionTypeEnum Type { get; set; }
        public string Description { get; set; }

    }
}
