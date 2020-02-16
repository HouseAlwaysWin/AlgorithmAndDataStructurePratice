using System.Collections.Generic;

namespace Samples.Algorithm
{
    public class MergeSortDemo
    {
        public static List<int> MergeSortV2(List<int> lst)
        {
            if (lst.Count <= 1)
                return lst;
            int mid = lst.Count / 2;
            List<int> left = new List<int>();  // 定义左侧List
            List<int> right = new List<int>(); // 定义右侧List
                                               // 以下兩個循環把 lst 分為左右兩個 List
            for (int i = 0; i < mid; i++)
                left.Add(lst[i]);
            for (int j = mid; j < lst.Count; j++)
                right.Add(lst[j]);
            left = MergeSortV2(left);
            right = MergeSortV2(right);
            var result = merge(left, right);
            return result;
        }
        /// <summary>
        /// 合併兩個已經排好序的List
        /// </summary>
        /// <param name="left">左側List</param>
        /// <param name="right">右側List</param>
        /// <returns></returns>
        static List<int> merge(List<int> left, List<int> right)
        {
            List<int> temp = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    temp.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    temp.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            if (left.Count > 0)
            {
                for (int i = 0; i < left.Count; i++)
                    temp.Add(left[i]);
            }
            if (right.Count > 0)
            {
                for (int i = 0; i < right.Count; i++)
                    temp.Add(right[i]);
            }
            return temp;
        }


        public static void MergeSortV1(int[] arr, int l, int r)
        {
            System.Console.WriteLine($"Splitting l r: {l} {r}");
            if (l < r)
            {
                int m = (l + r) / 2;

                MergeSortV1(arr, l, m);
                MergeSortV1(arr, m + 1, r);

                Merge(arr, l, m, r);
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            System.Console.WriteLine($"Merge l m r:{l} {m} {r}");
            int n1 = m - l + 1;
            int n2 = r - m;

            //temp arr
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            for (int j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            int z = 0, x = 0;
            int k = l;
            while (z < n1 && x < n2)
            {
                if (L[z] <= R[x])
                {
                    arr[k] = L[z];
                    z++;
                }
                else
                {
                    arr[k] = R[x];
                    x++;
                }
                k++;
            }

            while (z < n1)
            {
                arr[k] = L[z];
                z++;
                k++;
            }

            while (x < n2)
            {
                arr[k] = R[x];
                x++;
                k++;
            }

            System.Console.WriteLine($"After Merge:");
            for (int i = 0; i < n1; i++)
            {
                System.Console.WriteLine(arr[i] + " ");
            }
        }
    }
}