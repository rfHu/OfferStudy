/*
 冒泡排序
 两层遍历复杂度为O(n^2)
 */

using ForOffer.Extension;

namespace ForOffer
{
    public class BubbleSort
    {
        public static void BubbleSortFunc(int[] arr)
        {
            bool ChangeHappend = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                ChangeHappend = false;
                for (int j = arr.Length -1; j > i; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        ChangeHappend = true;
                        arr.ExchangeIndex(j, j - 1);
                    }
                }

                if (!ChangeHappend)
                {
                    return;
                }
            }
        }
    }
}