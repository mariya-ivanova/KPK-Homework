using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareAdvancedMaths
{
    class Tests
    {
        private const float FloatNumber = 100.0F;
        private const double DoubleNumber = 100.0;
        private const decimal DecimalNumber = 100.0M;

        public static void Main()
        {
            Console.WriteLine("Sqrt:");
            CompareAdvancedMaths.TestOperation(FloatNumber, "Sqrt");
            CompareAdvancedMaths.TestOperation(DoubleNumber, "Sqrt");
            CompareAdvancedMaths.TestOperation(DecimalNumber, "Sqrt");

            Console.WriteLine("Log:");
            CompareAdvancedMaths.TestOperation(FloatNumber, "Log");
            CompareAdvancedMaths.TestOperation(DoubleNumber, "Log");
            CompareAdvancedMaths.TestOperation(DecimalNumber, "Log");

            Console.WriteLine("Sin:");
            CompareAdvancedMaths.TestOperation(FloatNumber, "Sin");
            CompareAdvancedMaths.TestOperation(DoubleNumber, "Sin");
            CompareAdvancedMaths.TestOperation(DecimalNumber, "Sin");
        }
    }
}
