/*
 输入整数，输出此数字二进制中的1的个数
 */

namespace ForOffer
{
    public class NumberOf1
    {
        public static int NumberOf1Func(int n)
        {

            int count = 0;
            while (n != 0)
            {
                count++;
                n &= n - 1;
            }
            return count;
        }
        //不可换为/2，除法效率太低
        //此方法不可输入负数，会死循环


        public static int NumberOf1Func1(int n)
        {
            int count = 0;
            uint flag = 1;
            while (flag != 0)
            {
                if ((n & flag) != 0)
                {
                    count++;

                    flag = flag << 1;
                }

            }
            return count;
        }
        //可用解，但是必然循环int类型位数32次

        public static int NumberOf1Func2(int n)
        {
            int count = 0;

            while (n != 0)
            {
                count++;
                n = n & (n - 1);
            }

            return count;
        }
        //n 和 n-1 的二级制数在从最左到当前第一个1完全相反，与运算后全部归零，前面的不变

            //来自网络
            public static int NumberOf1Funcn(int n)
        {

            int count = 0;
            while ((n & 1) != 0)
            {
                count++;

                n = n >> 1;
            }
            return count;
        }

    }
}