using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LeetCode
{
    public class PalindromeNumber
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("Leetcode/9.IsPalindrome", false, 9)]
        static void MenuCilcked()
        {
            Debug.Log(IsPalindrome(121));
        }
#endif
        /// <summary>
        /// 算法有误，未来看看有没有救
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x < 10)
            {
                return true;
            }

            var length = (int)(Math.Floor(Math.Log10(x)) + 1);

            int firstNum = x / (int)Math.Pow(10, length - 1);
            int lastNum = x % 10;
            if (firstNum == lastNum)
            {
                return IsPalindrome((x - (lastNum * (int)Math.Pow(10, length - 1) + lastNum)) / 10);
            }
            else
            {
                return false;
            }
        }

        public static bool IsPalindrome1(int x)
        {
            // 特殊情况：
            // 如上所述，当 x < 0 时，x 不是回文数。
            // 同样地，如果数字的最后一位是 0，为了使该数字为回文，
            // 则其第一位数字也应该是 0
            // 只有 0 满足这一属性
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // 当数字长度为奇数时，我们可以通过 revertedNumber/10 去除处于中位的数字。
            // 例如，当输入为 12321 时，在 while 循环的末尾我们可以得到 x = 12，revertedNumber = 123，
            // 由于处于中位的数字不影响回文（它总是与自己相等），所以我们可以简单地将其去除。
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}