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
            answers = new HashSet<Answer>();
            UserMarks = new HashSet<UserMark>();
        }

        public int Id { get; set; }

        public int testid { get; set; }

        public int mark { get; set; }

        [Required]
        public string text { get; set; }

        [Required]
        public string opA { get; set; }

        [Required]
        public string opB { get; set; }

        public string opC { get; set; }

        public string opd { get; set; }

        [Required]
        [StringLength(10)]
        public string answer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> answers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMark> UserMarks { get; set; }

        public virtual Test Test { get; set; }
    }
}
