namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations;

    public partial class AnsweredQuestion
    {
        public int Id { get; set; }

        public int? Testid { get; set; }

        public int? Userid { get; set; }

        public int? Questionid { get; set; }

        [StringLength(10)]
        public string Useranswer { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
