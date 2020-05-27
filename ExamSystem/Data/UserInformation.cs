namespace ExamSystem.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserInformation")]
    public partial class UserInformation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(75)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(75)]
        public string PASSWORD { get; set; }

        [StringLength(20)]
        public string STATUS { get; set; }
    }
}
