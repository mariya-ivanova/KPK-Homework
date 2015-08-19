using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class NumberFormats 
    {
       public static readonly Dictionary<string, string> numberFormats = new Dictionary<string, string>() 
       {
        {"f", "{0:f2}"},
        {"%", "{0:p0}"},
        {"r", "{0,8}"}
       };

    }

}
