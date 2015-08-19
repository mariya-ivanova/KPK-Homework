using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _01.Assertions
{
    class AssertionsAlgorithms
    {
        internal static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array can not be null.");
            Debug.Assert(arr.Length != 0, "Array can not be empty.");
            Debug.Assert(startIndex < endIndex, "The start index can not be larger than the end index.");
            Debug.Assert(startIndex >= 0 && startIndex <= arr.Length - 1, "Invalid start index value.");
            Debug.Assert(endIndex >= 0 && endIndex <= arr.Length - 1, "Invalid end index value.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        internal static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        internal static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        internal static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array can not be null");
            Debug.Assert(arr.Length != 0, "You can not pass an empty array");
            Debug.Assert(startIndex < endIndex, "The start index can not be larger than the end index");
            Debug.Assert(startIndex >= 0, "Start index must be greater than or equal to 0.");
            Debug.Assert(endIndex > 0, "End index must be greater than 0.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the left half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }

        internal static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(arr.Length > 0, "Array is empty.");

            int length = arr.Length;
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(arr.Length == length, "Input and output arrays have different lengths.");
        }
    }
}
