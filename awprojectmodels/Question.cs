using System.ComponentModel.DataAnnotations;

namespace awprojectmodels
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Exam Name and Version is Required")]
        public string ExamVersion { get; set; } = null!;
        [Required(ErrorMessage = "Question is Required")]
        public string ExamQuestion { get; set; } = null!;
        [Required(ErrorMessage = "Answers are Required")]
        public List<string> Answers { get; set; } = null!;
        [Required(ErrorMessage = "Correct Answer is Required")]
        public int CorrectAnswer { get; set; }
        public string? SubjectDomain { get; set; }
    }
}
