using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.InheritanceAndPolymorphism
{
    public class Validator
    {
        public static void ValidateIfNegative(double number, string message)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void ValidateIfNullOrEmpty(string input, string message)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
