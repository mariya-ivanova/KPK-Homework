using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string name;
        private IList<Student> studentList;
        private IList<Course> courseList;

        public School(string name)
        {
            this.Name = name;
            this.studentList = new List<Student>();
            this.courseList = new List<Course>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public List<Student> StudentListInSchool
        {
            get
            {
                return new List<Student>(this.studentList);
            }
        }

        public List<Course> CourseListInSchool
        {
            get
            {
                return new List<Course>(this.courseList);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student cannot be null.");
            }

            if (this.studentList.Any(x => x.ClassNumber == student.ClassNumber))
            {
                throw new ArgumentException("Student with this number already exists.");
            }

            this.studentList.Add(student);
        }

        public void AddCourse(Course courseToAdd)
        {
            if (courseToAdd == null)
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            this.courseList.Add(courseToAdd);
        }
    }
}
