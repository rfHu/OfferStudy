
/*
 * 定义函数输入链表的头结点，翻转之，并返回新链表的头结点
 */

namespace ForOffer
{
    public class ReverseList
    {
        private static ListNode ReverseListFunc(ListNode head)
        {
            ListNode pReversedHead = null;
            ListNode pNode = head;
            ListNode pPrev = null;
            while (pNode != null)
            {
                ListNode pNext = pNode.M_pNext;

                if (pNext == null)
                {
                    pReversedHead = pNode;
                }

                pNode.M_pNext = pPrev;

                pPrev = pNode;
                pNode = pNext;
            }

            return pReversedHead;
        }
    }
}