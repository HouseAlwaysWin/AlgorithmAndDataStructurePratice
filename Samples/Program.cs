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
            // int[] list = new int[1000];
            // for (int i = 0; i < list.Length - 1; i++)
            // {
            //     Random random = new Random();
            //     list[i] = random.Next();
            // }
            int[] list = { 2, 1, 4, 6, 8, 9, 5, 7 };
            System.Console.WriteLine("MergeSort:");
            WatchDog.ShowPerformance<List<int>, List<int>>(MergeSortDemo.MergeSortV2, list.ToList(), false);
            System.Console.WriteLine("BubbleSort:");
            WatchDog.ShowPerformance(BubbleSortDemo.BubbleSort, list);
            System.Console.WriteLine("QuickSort:");
            WatchDog.ShowPerformance<int[], int, int>(QuickSortDemo.QuickSortV1, list, 0, list.Count() - 1);

        }
    }
}
