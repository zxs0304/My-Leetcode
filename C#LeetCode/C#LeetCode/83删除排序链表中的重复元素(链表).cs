using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _83删除排序链表中的重复元素
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

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode current = head;
            while(current != null)
            {
                while (current.next != null && current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                current = current.next;
            }
            return head;
        }

    }
}
