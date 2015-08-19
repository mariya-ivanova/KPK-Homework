using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Refactor_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int len = array.Length;
            for (int index = 0; index < len; index++)
            {
                array[index] = index;
            }

            int expectedValue = 3;
            bool valueFound = false;

            for (int i = 0; i < len; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        valueFound = true;
                    }
                }

                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
