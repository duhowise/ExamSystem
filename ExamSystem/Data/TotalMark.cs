namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations;

    public partial class TotalMark
    {
        public int Id { get; set; }

        public int? userid { get; set; }

        public int? testid { get; set; }

        [Required]
        [StringLength(10)]
        public string marks { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
