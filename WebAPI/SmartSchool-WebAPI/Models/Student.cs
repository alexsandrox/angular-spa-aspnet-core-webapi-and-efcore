using System;
using System.Collections.Generic;

namespace SmartSchool_WebAPI.Models
{
    public class Student
    {
        protected Student() { }
        public Student(int id, string firstName, string lastName, string document, string phonenumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Phonenumber = phonenumber;
            Email = email;
            CreatedAt = DateTime.UtcNow.ToLocalTime();
            UpdatedAt = DateTime.UtcNow.ToLocalTime();
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Phonenumber { get; private set; }
        public string Email { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // para fazer o relacionamento muitos para muitos
        public IEnumerable<StudentSubject> StudentsSubjects { get; private set; }
    }
}