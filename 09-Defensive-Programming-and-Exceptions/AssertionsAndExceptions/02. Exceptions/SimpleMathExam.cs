using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions
{
    class SimpleMathExam : Exam
    {
        private int problemsSolved;

        internal SimpleMathExam(int problemsSolved)
        {
            this.problemsSolved = problemsSolved;
        }

        internal int ProblemsSolved
        {
            get { return this.problemsSolved; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Count of solved problems should be between 0 and 10.");
                }

                this.problemsSolved = value;
            }
        }

        internal override ExamResult Check()
        {
            switch (this.ProblemsSolved)
            {
                case 0:
                    return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                case 1:
                    return new ExamResult(4, 2, 6, "Average result: nothing done.");
                case 2:
                    return new ExamResult(6, 2, 6, "Average result: nothing done.");
            }

            return new ExamResult(0, 0, 0, "Invalid number of problems solved!");
        }
    }
}
