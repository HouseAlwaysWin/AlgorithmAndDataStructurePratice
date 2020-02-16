namespace Samples.Algorithm
{
    public class QuickSortDemo
    {
        public static void QuickSortV1(int[] arr, int head, int tail)
        {
            if (head >= tail || arr == null || arr.Length <= 1)
            {
                return;
            }
            int i = head, j = tail, pivot = arr[(head + tail) / 2];
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    ++i;
                }
                while (arr[j] > pivot)
                {
                    --j;
                }
                if (i < j)
                {
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    ++i;
                    --j;
                }
                else if (i == j)
                {
                    ++i;
                }
            }
            QuickSortV1(arr, head, j);
            QuickSortV1(arr, i, tail);
        }

    }
}