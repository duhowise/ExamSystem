namespace ExamSystem.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answers = new HashSet<Answer>();
            UserMarks = new HashSet<UserMark>();
        }

        public int Id { get; set; }

        public int Testid { get; set; }

        public int Mark { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string OpA { get; set; }

        [Required]
        public string OpB { get; set; }

        public string OpC { get; set; }

        public string Opd { get; set; }

        [Required]
        [StringLength(10)]
        public string Answer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMark> UserMarks { get; set; }

        public virtual Test Test { get; set; }
    }
}
