using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{

    internal class _234回文链表_链表_
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
        //法一是记录到数组中，然后用双指针判断回文
        //法二是从中间截断，然后反转第二段链表，然后用双指针比较这两段链表
        public bool IsPalindrome(ListNode head)
        {
            ListNode midNode = GetMidNode(head);
            ListNode head2 = Reverse(midNode.next);
            
            // 第二段只可能比第一段 更短
            while (head2 != null)
            {
                if (head.val != head2.val)
                {
                    return false;
                }
                else
                {
                    head = head.next;
                    head2 = head2.next;
                }
            }
            return true;
        }
        //通过双指针快速获得中间节点
        //得到链表的中间节点 , 若为奇数个，那么中间节点属于前半个链表
        public ListNode GetMidNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        //反转链表
        public ListNode Reverse(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }

            return pre;
        }

    }
}
