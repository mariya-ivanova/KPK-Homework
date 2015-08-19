/* Refactor the following code to apply variable usage and naming best practices: */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrintStatistics
{
    class Statistics
    {
        public static void PrintStatistics(double[] arr)
        {
            double max = arr[0];
            int count = arr.Length;
            for (int i = 1; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Print("Max", max);

            double min = arr[0];
            for (int i = 1; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Print("Min", min);

            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }

            Print("Average", sum/count);
        }

        static void Print(string title, double value)
        {
            Console.WriteLine("{0}: {1}", title, value);
        }

        static void Main(string[] args)
        {
            double[] arr = new double[5] { 2, 25, 12, 30, 1 };
            PrintStatistics(arr);
        }
    }
}
