using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _61旋转链表
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

        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return null;
            }
            ListNode current = head;
            int length = 1;
            while (current.next != null) //current指向最后一个节点
            {
                current = current.next;
                length++;
            }
            current.next = head; //先形成一个环，然后在特定的位置断开环即可

            current = head;
            k = k % length;
            for(int i = 0;i<length - k - 1; i++) //假如一共5个节点，k=1，即新的头结点就是第5-k个，但是要获得新头结点的前一个节点，因此往后走5-k-1步，
            {
                current = current.next; //current指向新的头结点的前一个节点
            }

            ListNode newHead = current.next;
            current.next = null;
            return newHead;

        }


    }
}
