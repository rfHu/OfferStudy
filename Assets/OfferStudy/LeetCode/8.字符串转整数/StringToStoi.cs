/*
 * 请你来实现一个 atoi 函数，使其能将字符串转换成整数。
 *
 * 首先，该函数会根据需要丢弃无用的开头空格字符，直到寻找到第一个非空格的字符为止。
 *
 * 当我们寻找到的第一个非空字符为正或者负号时，则将该符号与之后面尽可能多的连续数字组合起来，作为该整数的正负号；假如第一个非空字符是数字，则直接将其与之后连续的数字字符组合起来，形成整数。
 * 
 * 该字符串除了有效的整数部分之后也可能会存在多余的字符，这些字符可以被忽略，它们对于函数不应该造成影响。
 * 
 * 注意：假如该字符串中的第一个非空格字符不是一个有效整数字符、字符串为空或字符串仅包含空白字符时，则你的函数不需要进行转换。
 * 
 * 在任何情况下，若函数不能进行有效的转换时，请返回 0。
 * 
 * 说明：
 * 
 * 假设我们的环境只能存储 32 位大小的有符号整数，那么其数值范围为 [−231,  231 − 1]。如果数值超过这个范围，请返回  INT_MAX (231 − 1) 或 INT_MIN (−231) 。
 */

using System;
using UnityEngine;

namespace LeetCode
{
    public class StringToStoi
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("Leetcode/8.StrtoAtoi", false, 8)]
        static void MenuCilcked()
        {
            Debug.Log(MyAtoi("-000000000000001"));
        }
#endif

        /// <summary>
        /// 自我尝试的解法，不对尚需修改
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int MyAtoi(string str)
        {
            //为空直接返回
            if (string.IsNullOrEmpty(str))
                return 0;

            int startIndex = -1;
            int length = 0;
            int firstnonspaceIndex = -1;
            bool isNegative = false;

            for (int i = 0; i < str.Length; i++)
            {
                var tmp = str[i];
                if (firstnonspaceIndex == -1 && str[i] != ' ')
                {
                    firstnonspaceIndex = i;
                }

                if (tmp >= 48 && tmp <= 57)
                {
                    startIndex = i;
                    break;
                }
            }
            //字符串中无数字
            if (startIndex == -1)
            {
                return 0;
            }
            //判断是否为负数
            if (startIndex - 1 >= 0 && str[startIndex - 1] == 45) isNegative = true;
            if (isNegative && startIndex - firstnonspaceIndex != 1)
            {
                return 0;
            }
            if (!isNegative && startIndex - firstnonspaceIndex != 0 && !((startIndex - firstnonspaceIndex == 1) && str[startIndex - 1] == '+'))
            {
                return 0;
            }

            //获得长度
            while ((startIndex + length < str.Length) && str[startIndex + length] >= 48 && str[startIndex + length] <= 57)
            {
                length++;
            }
            
            while (startIndex < startIndex + length - 2)
            {
                if (str[startIndex] == '0')
                {
                    startIndex++;
                    length--;
                }
                else
                {
                    break;
                }
            }

            if (length > 10)
            {
                return isNegative ? int.MinValue : int.MaxValue;
            }
            else if (length < 10)
            {
                var mun = int.Parse(isNegative ? str.Substring(startIndex - 1, length + 1) : str.Substring(startIndex, length));
                return isNegative ? -Math.Abs(mun) : mun;
            }
            else
            {
                if (isNegative)
                {
                    if (int.Parse(str.Substring(startIndex, length - 1)) > int.MaxValue / 10 || (int.Parse(str.Substring(startIndex, length - 1)) == int.MaxValue / 10 && str[startIndex + length - 1] > 56))
                    {
                        return int.MinValue;
                    }
                    else
                    {
                        return int.Parse(str.Substring(startIndex - 1, length + 1));
                    }
                }
                else
                {
                    if (int.Parse(str.Substring(startIndex, length - 1)) > int.MaxValue / 10 || (int.Parse(str.Substring(startIndex, length - 1)) == int.MaxValue / 10 && str[startIndex + length - 1] > 55))
                    {
                        return int.MaxValue;
                    }
                    else
                    {
                        return int.Parse(str.Substring(startIndex, length));
                    }
                }
            }
        }
    }
}