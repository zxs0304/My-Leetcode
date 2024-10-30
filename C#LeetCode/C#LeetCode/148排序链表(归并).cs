using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _148排序链表_归并_
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode head2 = Split(head);
            ListNode sortedHead1 =  SortList(head);
            ListNode sortedHead2 = SortList(head2);
            return Merge(sortedHead1,sortedHead2);

        }

        public ListNode Split(ListNode head)
        {
            ListNode fast = head.next;
            ListNode slow = head;
            while ( fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode head2 =  slow.next;
            slow.next = null;
            return head2;
        }

        public ListNode Merge(ListNode head1 , ListNode head2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            while (head1 != null && head2 != null)
            {
                if (head1.val < head2.val)
                {
                    current.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    current.next = head2;
                    head2 = head2.next;
                }
                current = current.next;
            }

            if (head1 != null)
            {
                current.next = head1;
            }
            if (head2 != null)
            {
                current.next = head2;
            }

            return dummy.next;
        }

    }
}
