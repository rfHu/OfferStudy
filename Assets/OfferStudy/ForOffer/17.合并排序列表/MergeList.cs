/*
 * 合并两个排序的列表，依然是排序的
 */


namespace ForOffer {
    public class MergeList
    {
        public static ListNode MergeListFunc(ListNode head1, ListNode head2)
        {
            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;

            ListNode pMergedHead = null;

            if (head1.M_nValue < head2.M_nValue)
            {
                pMergedHead = head1;
                pMergedHead.M_pNext = MergeListFunc(head1.M_pNext, head2);
            }
            else
            {
                pMergedHead = head2;
                pMergedHead.M_pNext = MergeListFunc(head1, head2.M_pNext);
            }

            return pMergedHead;
        }
    }
}