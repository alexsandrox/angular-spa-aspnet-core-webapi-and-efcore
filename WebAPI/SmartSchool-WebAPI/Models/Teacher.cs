namespace SmartSchool_WebAPI.Models
{
    public class Teacher
    {
        protected Teacher() { }
        public Teacher(string id, string firstName, string lastName, string subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Subject { get; private set; }
    }
}