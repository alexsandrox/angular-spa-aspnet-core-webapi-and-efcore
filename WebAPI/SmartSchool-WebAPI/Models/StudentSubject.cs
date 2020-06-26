namespace SmartSchool_WebAPI.Models
{
    public class StudentSubject
    {
        public StudentSubject() { }
        public StudentSubject(int studentId, int subjectId)
        {
            StudentId = studentId;
            SubjectId = subjectId;
        }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}