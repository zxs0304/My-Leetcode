using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{

    internal class _141环形链表_双指针_
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }


        public bool HasCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {



                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return true;
                }

            }
            return false;
        }


    }


}
