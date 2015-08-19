using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecreasingAbsoluteDifferences
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] sequences = new string[n];
        /*
        string[] sequences = {
        "10 7 4 2 1",
        "5 1 4 2 -1",
        "5 1 4 2 0 -1 -2 -2",
        "4 1 4 2 3"
    };
       */
        /*
        string[] sequences = {
        "5 3 2 1 0",
        "7 4 2",
        "4 7 4",
        "4 7 5",
        "8 4 2 3"
    };
        */

        for (int i = 0; i < n; i++)
        {
            sequences[i] = Console.ReadLine();
        }

        for (int i = 0; i < n; i++)
        {
            long[] numbers = sequences[i].Split(' ').Select(long.Parse).ToArray();
            long[] absoluteSequence = AbsoluteSequence(numbers);
            bool result = isDecreasingSequence(absoluteSequence);
            Console.WriteLine(result);
        }

    }

    static long[] AbsoluteSequence(long[] numbers)
    {
        long[] result = new long[numbers.Length - 1];
        for (int i = 1; i < numbers.Length; i++)
        {
            result[i - 1] = Math.Abs(numbers[i] - numbers[i - 1]);
        }
        return result;
    }

    static bool isDecreasingSequence(long[] absoluteSequence)
    {
        for (int i = 1; i < absoluteSequence.Length; i++)
        {
            if (absoluteSequence[i - 1] < absoluteSequence[i] ||
               (absoluteSequence[i - 1] - absoluteSequence[i] != 0 &&
                absoluteSequence[i - 1] - absoluteSequence[i] != 1))
            {
                return false;
            }
        }

        return true;
    }

}

