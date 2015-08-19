using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareSimpleMaths
{
    class Tests
    {
        private const int IntNumber = 1;
        private const long LongNumber = 1L;
        private const float FloatNumber = 1.0F;
        private const double DoubleNumber = 1.0;
        private const decimal DecimalNumber = 1.0M;

        public static void Main()
        {
            Console.WriteLine("Addition:");
            CompareSimpleMaths.TestOperation(IntNumber, "Addition");
            CompareSimpleMaths.TestOperation(LongNumber, "Addition");
            CompareSimpleMaths.TestOperation(FloatNumber, "Addition");
            CompareSimpleMaths.TestOperation(DoubleNumber, "Addition");
            CompareSimpleMaths.TestOperation(DecimalNumber, "Addition");

            Console.WriteLine("Subtraction:");
            CompareSimpleMaths.TestOperation(IntNumber, "Subtraction");
            CompareSimpleMaths.TestOperation(LongNumber, "Subtraction");
            CompareSimpleMaths.TestOperation(FloatNumber, "Subtraction");
            CompareSimpleMaths.TestOperation(DoubleNumber, "Subtraction");
            CompareSimpleMaths.TestOperation(DecimalNumber, "Subtraction");

            Console.WriteLine("Division:");
            CompareSimpleMaths.TestOperation(IntNumber, "Division");
            CompareSimpleMaths.TestOperation(LongNumber, "Division");
            CompareSimpleMaths.TestOperation(FloatNumber, "Division");
            CompareSimpleMaths.TestOperation(DoubleNumber, "Division");
            CompareSimpleMaths.TestOperation(DecimalNumber, "Division");

            Console.WriteLine("Multiplication:");
            CompareSimpleMaths.TestOperation(IntNumber, "Multiplication");
            CompareSimpleMaths.TestOperation(LongNumber, "Multiplication");
            CompareSimpleMaths.TestOperation(FloatNumber, "Multiplication");
            CompareSimpleMaths.TestOperation(DoubleNumber, "Multiplication");
            CompareSimpleMaths.TestOperation(DecimalNumber, "Multiplication");

            Console.WriteLine("Increment:");
            CompareSimpleMaths.TestOperation(IntNumber, "Increment");
            CompareSimpleMaths.TestOperation(LongNumber, "Increment");
            CompareSimpleMaths.TestOperation(FloatNumber, "Increment");
            CompareSimpleMaths.TestOperation(DoubleNumber, "Increment");
            CompareSimpleMaths.TestOperation(DecimalNumber, "Increment");
        }
    }
}
