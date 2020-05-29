namespace ExamSystem.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            AnsweredQuestions = new HashSet<AnsweredQuestion>();
            TotalMarks = new HashSet<TotalMark>();
            UserMarks = new HashSet<UserMark>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(75)]
        public string Name { get; set; }

        [Required]
        [StringLength(75)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string UserType { get; set; }

        public int? Testid { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public int? Position { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnsweredQuestion> AnsweredQuestions { get; set; }

        public virtual Test Test { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalMark> TotalMarks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMark> UserMarks { get; set; }
    }
}
