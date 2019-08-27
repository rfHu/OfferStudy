/*
 * 顺时针输出二维数组
 */

//首先把问题拆解，先判断输出几个顺时针，再思考每个顺时针怎么输出

using UnityEngine;

namespace ForOffer
{
    public class PrintMatrixClockWisely
    {
        public static void PrintMatrixClockWiselyFunc(int[,] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return;
            }

            int start = 0;
            while (numbers.GetLength(0) > start * 2 && numbers.GetLength(1) > start* 2)
            {
                PrintMatrixInCircle(numbers, start);
                start++;
            }
        }

        private static void PrintMatrixInCircle(int[,] numbers, int start)
        {
            int columns = numbers.GetLength(0);
            int rows = numbers.GetLength(1);

            int endX = columns - 1 - start;
            int endY = rows - 1 - start;

            for (int i = start; i < endX; i++)
            {
                int number = numbers[start, i];
                Debug.Log(number);
            }

            if (start < endY)
            {
                for (int i = start + 1; i < endY; i++)
                {
                    int number = numbers[i, endX];
                    Debug.Log(number);
                }
            }

            if (start < endX && start < endY)
            {
                for (int i = endX - 1; i >= start; i--)
                {
                    int number = numbers[endY, i];
                    Debug.Log(number);
                }
            }

            if (start <endX && start < endY - 1)
            {
                for (int i = endY - 1; i >= start + 1; i++)
                {
                    int number = numbers[i, start];
                    Debug.Log(number);
                }
            }
        }
    }
}