using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exceptions
{
    class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < MinScore)
                {
                    throw new ArgumentOutOfRangeException("Scroe must have a positive value");
                }

                this.score = value;
            }
        }

        internal override ExamResult Check()
        {
            if (this.Score < MinScore || this.Score > MaxScore)
            {
                throw new ArgumentOutOfRangeException("Scroe must be in the range beween 1 and 100");
            }
            else
            {
                return new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
            }
        }
    }
}
