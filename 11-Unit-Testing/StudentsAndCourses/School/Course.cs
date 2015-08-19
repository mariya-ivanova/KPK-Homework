using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private const int MaxStudentsCount = 30;

        private string name;
        private List<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count > MaxStudentsCount)
            {
                throw new ArgumentOutOfRangeException(string.Format("Students count should be between 0 and {0}.", MaxStudentsCount));
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (studentToRemove == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            this.students.Remove(studentToRemove);
        }
    }
}
