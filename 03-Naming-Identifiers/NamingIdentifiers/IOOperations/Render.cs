using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOperations
{
    class Render
    {
        const int MaxCount = 6;

        public static void Main()
        {
            IOOperations.Printer inputOutput = new IOOperations.Printer();
        //    Printer inputOutput = new Printer();
            inputOutput.convertToString(true);
        }
    }

}
