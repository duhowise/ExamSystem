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
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(75)]
        public string Password { get; set; }

        [StringLength(20)]
        public string Status { get; set; }
    }
}
