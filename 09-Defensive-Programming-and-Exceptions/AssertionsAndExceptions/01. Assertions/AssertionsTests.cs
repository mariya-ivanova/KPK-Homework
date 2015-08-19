using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01.Assertions
{
    class AssertionsTests
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));

            AssertionsAlgorithms.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            AssertionsAlgorithms.SelectionSort(new int[0]); // Test sorting empty array
            AssertionsAlgorithms.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(AssertionsAlgorithms.BinarySearch(arr, -1000));
            Console.WriteLine(AssertionsAlgorithms.BinarySearch(arr, 0));
            Console.WriteLine(AssertionsAlgorithms.BinarySearch(arr, 17));
            Console.WriteLine(AssertionsAlgorithms.BinarySearch(arr, 10));
            Console.WriteLine(AssertionsAlgorithms.BinarySearch(arr, 1000));
        }
    }
}
