namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations;

    public partial class TotalMark
    {
        public int Id { get; set; }

        public int? Userid { get; set; }

        public int? Testid { get; set; }

        [Required]
        [StringLength(10)]
        public string Marks { get; set; }

        public virtual Test Test { get; set; }

        public virtual User User { get; set; }
    }
}
