using System;

namespace SmartSchool_WebAPI.Models
{
    public class Student
    {
        protected Student() { }
        public Student(string id, string firstName, string lastName, string document, string phonenumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Phonenumber = phonenumber;
            Email = email;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Phonenumber { get; private set; }
        public string Email { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}