using System;

namespace Methods
{
    class Student
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        public Student(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName","The value cannot be null and cannot be empty");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName", "The value cannot be null and cannot be empty");
                }
                this.lastName = value;
            }
        }
        public DateTime DateOfBirth { get; set; }


        public bool IsOlderThan(Student other)
        {
            return this.DateOfBirth < other.DateOfBirth;
        }
    }
}
