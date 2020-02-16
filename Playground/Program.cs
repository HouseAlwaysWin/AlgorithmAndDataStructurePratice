using System.Linq;
using System;
using System.Collections.Generic;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>
            {
                2,6,7,3,4
            };


            list = Sort(list.ToList());

            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }

        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }
            int mid = list.Count / 2;
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            for (int i = 0; i < mid; i++)
            {
                Left.Add(list[i]);
            }
            for (int j = mid; j < list.Count; j++)
            {
                Right.Add(list[j]);
            }

            Left = Sort(Left);
            Right = Sort(Right);
            return Merge(Left, Right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> tmp = new List<int>();
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    tmp.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    tmp.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            if (left.Count() > 0)
            {
                for (int i = 0; i < left.Count; i++)
                    tmp.Add(left[0]);
            }

            if (right.Count() > 0)
            {
                for (int i = 0; i < right.Count; i++)
                    tmp.Add(right[0]);
            }

            return tmp;
        }

    }
}
