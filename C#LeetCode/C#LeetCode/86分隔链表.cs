using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _86分隔链表
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
        public ListNode Partition(ListNode head, int x)
        {
            // 创建两个虚拟头节点
            ListNode lessHead = new ListNode(0);
            ListNode greaterHead = new ListNode(0);

            // 当前指针
            ListNode less = lessHead;
            ListNode greater = greaterHead;

            while (head != null) //不能循环两边原链表，直接在原链表上做修改，因为当第一遍在原链表上修改时，第二遍遍历的就不是原链表了
            {
                if (head.val < x)
                {
                    less.next = head;
                    less = less.next;
                }
                else
                {
                    greater.next = head;
                    greater = greater.next;
                }

                head = head.next;
            }

            less.next = greaterHead.next;
            return lessHead.next;

        }
    }
}
