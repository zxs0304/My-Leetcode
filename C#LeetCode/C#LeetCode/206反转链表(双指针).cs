using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _206反转链表_双指针_
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

        public ListNode ReverseList(ListNode head)
        {
            ListNode current = head; 
            ListNode previous = null;
            while (current != null)  
            {
                ListNode temp = current.next; //改变当前节点的next为前一个节点后，原本当前节点的下一个就访问不到了，所以要在改之前暂存一下
                current.next = previous;

                previous = current; 
                current = temp; //重新赋值current为原本的下一个节点
            }
            return previous;

        }


    }
}
