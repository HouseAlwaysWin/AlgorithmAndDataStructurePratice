using System.Linq;
using System.Collections.Generic;
using System;
using Samples.Algorithm;
using SolutionLib.Tools;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[150];
            for (int i = 0; i < list.Length - 1; i++)
            {
                Random random = new Random();
                list[i] = random.Next();
            }
            // System.Console.WriteLine("MergeSort:");
            // WatchDog.ShowPerformance<List<int>, List<int>>(MergeSortDemo.MergeSortV2, list.ToList(), false);
            // System.Console.WriteLine("BubbleSort:");
            // WatchDog.ShowPerformance(BubbleSortDemo.BubbleSort, list);
            System.Console.WriteLine("QuickSort:");
            WatchDog.ShowPerformance<int[], int, int>(QuickSortDemo.QuickSortV1, list, 0, list.Count() - 1);

        }
    }
}
