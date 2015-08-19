using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace _02.CompareSimpleMaths
{
    internal static class CompareSimpleMaths
    {
        private const int StepsCount = 1000000; 
        private const int LoopsCount = 10; 
        private const int OperationStep = 1;

        private static Stopwatch watchTime = new Stopwatch();
        private static List<int> results = new List<int>(LoopsCount);

        internal static void TestOperation(dynamic number, string operation)
        {
            results.Clear();
            for (int i = 0; i < LoopsCount; i++)
            {
                watchTime.Reset();
                watchTime.Start();
                for (int j = 0; j < StepsCount; j++)
                {
                      switch (operation)
                      {
                          case "Addition":
                              number += OperationStep;
                              break;
                          case "Subtraction":
                              number -= OperationStep;
                              break;
                          case "Division":
                              number /= OperationStep;
                              break;
                          case "Multiplication":
                              number *= OperationStep;
                              break;
                          case "Increment":
                              number++;
                              break;
                          default:
                              throw new InvalidOperationException("Invalid operation!");
                      }
                }

                watchTime.Stop();
                results.Add(watchTime.Elapsed.Milliseconds);
            }

            double averageResult = results.Average();
            Console.WriteLine("Operation {0} with {1} finished in {2} miliseconds", operation, number.GetType().Name, averageResult);
        }

    }
}
