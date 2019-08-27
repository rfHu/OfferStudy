/*
 * 输入一个整数数组，并根据要求把元素重新分布在数组的前面或后面
 */

using System;
using UnityEngine;

public class Reorder
{
#if UNITY_EDITOR
    [UnityEditor.MenuItem("ForOffer/14.Reorder", false, 14)]
    static void MenuCilcked()
    {
        int[] tmp = { 48, 2, 5, 17, 32, 81, 77, 60 };
        ReorderFunc(tmp, isEven);

        foreach (var item in tmp)
        {
            Debug.Log(item);
        }
    }
#endif

    static void ReorderFunc(int[] arr, Func<int, bool> func)
    {
        var begin = 0;
        var end = arr.Length - 1;

        while (begin < end)
        {
            while (begin < end && !func(arr[begin]))
            {
                begin++;
            }

            while (begin < end && func(arr[end]))
            {
                end--;
            }

            if (begin < end)
            {
                int tmp = arr[begin];
                arr[begin] = arr[end];
                arr[end] = tmp;
            }
        }
    }

    /// <summary>
    /// 判断是否为偶数
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    static bool isEven(int n)
    {
        var isTrue = (n & 1) == 0;

        return isTrue;
    }


}
