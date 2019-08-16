/*
 选择排序
 O(n^2)
 */

using ForOffer.Extension;

namespace ForOffer
{
    public class SelctionSort
    {
        public static void SelctionSortFunc(int[] arr)
        {
            int minIndex;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    arr.ExchangeIndex(i, minIndex);
                }
            }
        }
    }
}