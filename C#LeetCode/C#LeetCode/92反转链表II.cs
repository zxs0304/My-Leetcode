using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _92反转链表II
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
        //建议看leetcode上灵神视频
        //在206题的做法的基础上，当反转一个链表完成以后，此时的current指向的是原链表的最后一个节点的next,也即为null(即反转后链表的头结点的前驱)
        //此时的previous指向的是原链表的最后一个节点(即反转后链表的头结点)
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode beforeLeft = dummy;
            for(int i = 1; i < left; i++)
            {
                beforeLeft = beforeLeft.next; //beforeLeft 指向反转链表的第一个节点的前一个节点
                                              //(找到他是为了后期改他的next为反转链表的最后一个节点,
                                              //以及通过beforeleft.next来找到反转链表的第一个节点，并修改它的next为反转链表最后一个节点的next)
            }

            ListNode current = beforeLeft.next; //current初始化为要反转链表的第一个节点,并重复206题的做法
            ListNode previous = null;
            for(int i = 0;i <= right - left; i++)
            {
                ListNode temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            beforeLeft.next.next = current; 
            beforeLeft.next = previous;


            return dummy.next;
        }


    }

}
