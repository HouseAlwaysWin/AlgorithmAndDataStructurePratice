using System.Linq;
using System;
using System.Collections.Generic;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] list = new int[150];
            // for (int i = 0; i < list.Length - 1; i++)
            // {
            //     Random random = new Random();
            //     list[i] = random.Next();
            // }

            int[] list = { 4, 3, 6, 8, 5, 18, 0, 9 };

            QuickSort(list, 0, list.Count() - 1);

            foreach (var num in list)
            {
                System.Console.WriteLine(num);
            }

        }

        public static void QuickSort(int[] arr, int head, int tail)
        {
            if (head >= tail || arr == null || arr.Length <= 1)
            {
                return;
            }

            var pivot = arr[(head + tail) / 2];
            int tmpHead = head, tmpTail = tail;
            while (tmpHead <= tmpTail)
            {
                while (arr[tmpHead] < pivot)
                {
                    ++tmpHead;
                }

                while (arr[tmpTail] > pivot)
                {
                    --tmpTail;
                }
                if (tmpHead < tmpTail)
                {
                    int tmp = arr[tmpHead];
                    arr[tmpHead] = arr[tmpTail];
                    arr[tmpTail] = tmp;
                    ++tmpHead;
                    --tmpTail;
                }
                else if (tmpHead == tmpTail)
                {
                    ++tmpHead;
                }
            }



            QuickSort(arr, head, tmpTail);
            QuickSort(arr, tmpHead, tail);
        }


    }
}
