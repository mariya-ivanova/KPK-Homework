using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private const int MinclassNumber = 10000;
        private const int MaxclassNumber = 99999;

        private string name;
        private int classNumber;

        public Student(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name should not be empty");
                }

                this.name = value;
            }
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            private set
            {
                if (value < MinclassNumber || value > MaxclassNumber)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Class number must be between {0} and {1}", MinclassNumber, MaxclassNumber));
                }

                this.classNumber = value;

            }
        }

    }
}
