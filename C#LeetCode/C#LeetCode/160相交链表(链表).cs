using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _160相交链表_链表_
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (headA != null)
            {
                set.Add(headA);
                headA = headA.next; 
            }
            while (headB != null)
            {
                if (set.Contains(headB))
                {
                    return headB;
                }
            }

            return null;
        }


    }
}
