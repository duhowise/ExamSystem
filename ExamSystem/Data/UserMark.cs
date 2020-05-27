namespace ExamSystem.Data
{
    public partial class UserMark
    {
        public int Id { get; set; }

        public int Userid { get; set; }

        public int Testid { get; set; }

        public int Questionid { get; set; }

        public int Mark { get; set; }

        public virtual Question Question { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
