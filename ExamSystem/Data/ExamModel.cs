namespace ExamSystem.Data
{
    using System.Data.Entity;

    public partial class ExamModel : DbContext
    {
        public ExamModel()
            : base("name=ExamDbContext")
        {
        }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<AnsweredQuestion> AnsweredQuestions { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TotalMark> TotalMarks { get; set; }
        public virtual DbSet<UserMark> UserMarks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<NamesTestsadnScore> NamesTestsAndScores { get; set; }
        public virtual DbSet<UserInformation> UserInformation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnsweredQuestion>()
                .Property(e => e.useranswer)
                .IsFixedLength();

            modelBuilder.Entity<AnsweredQuestion>()
                .Property(e => e.tempass)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .Property(e => e.answer)
                .IsFixedLength();

            modelBuilder.Entity<Question>()
                .HasMany(e => e.UserMarks)
                .WithRequired(e => e.Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Questions)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.UserMarks)
                .WithRequired(e => e.Test)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TotalMark>()
                .Property(e => e.marks)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserMarks)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<NamesTestsadnScore>()
                .Property(e => e.marks)
                .IsFixedLength();
        }
    }
}
