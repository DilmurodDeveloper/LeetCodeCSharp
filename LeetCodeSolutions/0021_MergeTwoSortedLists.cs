﻿//- - - - - - - - - - - - - - - - - - - -
// Merge Two Sorted Lists - LeetCode #21
//- - - - - - - - - - - - - - - - - - - -

namespace LeetCodeSolutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        
        public ListNode(
            int val = 0,
            ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(-1);
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            current.next = list1 ?? list2;

            return dummy.next;
        }
    }

}
