using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _142环形链表
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
        // 法一是哈希表法，法二双指针看K神题解
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (true)
            {
                if (fast == null || fast.next == null) 
                    return null;
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow) break;
            }
            // 设链表 非环部分长度为a 环部分长度为b
            //此时 fast = 2 * slow  因为fast速度是slow的2倍
            //又   fast = slow + (n * b)   因为fast此时比slow多走了n圈
            //因此此时 slow = n * b
            //此时让fast从head开始，fast和slow每次走1步
            //那么再次相遇时，他们一定在入口相遇， fast = a + (0*b) ， slow = a + (n * b)
            fast = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return fast;


        }
    }
}
