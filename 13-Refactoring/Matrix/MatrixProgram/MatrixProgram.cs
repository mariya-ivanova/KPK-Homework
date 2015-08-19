using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;

namespace MatrixProgram
{
    class MatrixProgram
    {
        static void Main(string[] args)
        {
            WalkInMatrix matrix = new WalkInMatrix(6);
            Console.WriteLine(matrix);
        }
    }
}
