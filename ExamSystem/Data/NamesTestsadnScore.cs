namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class NamesTestsadnScore
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column("NAME OF STUDENT", Order = 1)]
        [StringLength(75)]
        public string NameOfStudent { get; set; }

        [Key]
        [Column("TEST TAKEN", Order = 2)]
        [StringLength(50)]
        public string TestTaken { get; set; }

        public decimal Marks { get; set; }
    }
}
