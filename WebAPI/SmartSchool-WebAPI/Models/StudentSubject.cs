namespace SmartSchool_WebAPI.Models
{
    public class StudentSubject
    {
        public StudentSubject() { }
        public StudentSubject(string studentId, string subjectId)
        {
            StudentId = studentId;
            SubjectId = subjectId;
        }

        public string StudentId { get; set; }
        public Student Student { get; set; }
        public string SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}