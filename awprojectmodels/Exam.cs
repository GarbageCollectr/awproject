using System.ComponentModel.DataAnnotations;

namespace awprojectmodels
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string ExamBank { get; set; } = null!;
        public DateTime DateTime { get; set; }
        //[Display(Name="Exam Score")]
        //public float Score { get; set; }
        //public List<Question> ExamQuestions { get; set; }
    }
}
