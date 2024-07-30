namespace SFaSMS.Models
{
    public class Exam
    {
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        public float ExamScore { get; set; }
        public string? Grade { get; set; }
        public string? GPA { get; set; }
        public string? SubjectName { get; set; }
    }
}
