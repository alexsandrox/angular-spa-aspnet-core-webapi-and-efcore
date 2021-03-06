using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Subject
    {
        protected Subject() { }
        public Subject(int id, string name, int teacherId)
        {
            this.Id = id;
            this.Name = name;
            this.TeacherId = teacherId;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int TeacherId { get; private set; }
        public Teacher Teacher { get; private set; }

        // para fazer o relacionamento muitos para muitos
        public IEnumerable<StudentSubject> StudentsSubjects { get; private set; }
    }
}