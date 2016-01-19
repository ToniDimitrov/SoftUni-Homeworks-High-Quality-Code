using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        protected Course(string name, string teacherName, IList<string> students)
        {
            this.CourseName = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public IList<string> Students { get; set; }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            return "{ " + string.Join(", ", this.Students) + " }";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0} {{ Name = ", this.GetType().Name));
            result.Append(this.CourseName);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }
    }
}
