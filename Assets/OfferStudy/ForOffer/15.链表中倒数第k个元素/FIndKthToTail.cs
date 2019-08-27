using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ForOffer
{
    public class FIndKthToTail
    {
#if UNITY_EDITOR
        //[UnityEditor.MenuItem("ForOffer/6.SameOrNot", false, 6)]
        //static void MenuCilcked()
        //{

        //}
#endif

        private static ListNode FindKthToTailFunc(ListNode listHead, uint k)
        {
            if (listHead == null || k == 0)
            {
                return null;
            }

            ListNode head = listHead;
            ListNode target = null;

            for (uint i = 0; i < k - 1; i++)
            {
                if (head.M_pNext != null)
                {
                    head = head.M_pNext;
                }
                else
                {
                    return null;
                }
            }

            target = listHead;

            while (head.M_pNext != null)
            {
                head = head.M_pNext;
                target = target.M_pNext;
            }

            return target;
        }

    }
}