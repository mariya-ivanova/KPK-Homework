﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.InheritanceAndPolymorphism
{
    class LocalCourse : Course
    {
        private string lab;

        internal LocalCourse(string courseName)
            : base(courseName)
        {
        }

        internal LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        internal LocalCourse(string courseName, string teacherName, string lab)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        internal string Lab
        {
            get
            {
                return this.lab;
            }

            private set
            {
                Validator.ValidateIfNullOrEmpty(value, "Lab can not be an empty string");
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());

            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");

            return result.ToString();
        }

        internal void AddLab(string labName)
        {
            this.Lab = labName;
        }
    }
}
