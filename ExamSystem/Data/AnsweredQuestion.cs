namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations;

    public partial class AnsweredQuestion
    {
        public int Id { get; set; }

        public int? testid { get; set; }

        public int? userid { get; set; }

        public int? questionid { get; set; }

        [StringLength(10)]
        public string useranswer { get; set; }

        public string temp { get; set; }

        [StringLength(10)]
        public string tempass { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
