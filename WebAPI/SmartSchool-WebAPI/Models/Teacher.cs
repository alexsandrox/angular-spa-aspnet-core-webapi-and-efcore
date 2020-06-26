using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Teacher
    {
        protected Teacher() { }
        public Teacher(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public IEnumerable<Subject> Subjects { get; private set; }
    }
}