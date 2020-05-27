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
        public string NAME_OF_STUDENT { get; set; }

        [Key]
        [Column("TEST TAKEN", Order = 2)]
        [StringLength(50)]
        public string TEST_TAKEN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string marks { get; set; }
    }
}
