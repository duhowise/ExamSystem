namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("answer")]
    public partial class Answer
    {
        public int Id { get; set; }

        public int? QuestionId { get; set; }

        public string QuestionAnswer { get; set; }

        public int? TestId { get; set; }

        public virtual Question Question { get; set; }

        public virtual Test Test { get; set; }
    }
}
