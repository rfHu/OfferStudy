using UnityEngine;

namespace ForOffer
{


    public class Fibonacci
    {
#if UNITY_EDITOR
        [UnityEditor.MenuItem("ForOffer/7.Fibonacci", false, 7)]
        static void MenuCilcked()
        {
            Debug.Log(FibonacciFunc(0));
            Debug.Log(FibonacciFunc1(0));
        }
#endif

        public static int FibonacciFunc(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciFunc(n - 1) + FibonacciFunc(n - 2);
            }
        }

        public static int FibonacciFunc1(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            int fNum = 0;
            int sNum = 1;

            for (int i = 2; i <= n; i++)
            {
                int tmp = fNum + sNum;
                fNum = sNum;
                sNum = tmp;
            }

            return sNum;
        }
    }
}