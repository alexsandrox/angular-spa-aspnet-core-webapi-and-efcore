using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Subject
    {
        protected Subject() { }
        public Subject(string id, string name, string teacherId)
        {
            this.Id = id;
            this.Name = name;
            this.TeacherId = teacherId;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string TeacherId { get; private set; }
        public Teacher Teacher { get; private set; }

        // para fazer o relacionamento muitos para muitos
        public IEnumerable<StudentSubject> StudentsSubjects { get; private set; }
    }
}