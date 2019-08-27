using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 给定单项链表的头指针和一个结点指针，在O(1)时间内删除此节点
 */

namespace ForOffer
{
    public class ListNode
    {
        public int M_nValue;
        public ListNode M_pNext;
    }

    public class DeleteNodeO1
    {
        void DeleteNode(ListNode pListHead, ListNode pToBeDeleted)
        {
            if (pListHead == null || pToBeDeleted == null)
            {
                return;
            }

            if (pToBeDeleted.M_pNext != null)
            {
                var next = pToBeDeleted.M_pNext;
            }
        }
    }
}