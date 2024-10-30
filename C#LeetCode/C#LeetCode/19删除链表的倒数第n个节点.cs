using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _19删除链表的倒数第n个节点
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
        //双指针法
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0); //因为要找到被删除节点的前一个节点，且被删除节点可能是头结点，因此要加一个哨兵节点
            dummy.next = head;
            ListNode fast = dummy;
            ListNode slow = dummy;
            //由于要找到被删除节点的前一个节点，因此fast比slow先走n+1步
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            ListNode removeNode = slow.next;
            slow.next = removeNode.next;

            return dummy.next;

        }

        //递归法
        public ListNode RemoveNthFromEnd2(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0); //因为要找到被删除节点的前一个节点，且被删除节点可能是头结点，因此要加一个哨兵节点
            dummy.next = head;
            DiGui(dummy,n);

            return dummy.next;
        }
        public int DiGui(ListNode current , int n) //return的数字表示的是当前节点后面还有几个节点,所以当收到return为n时，表示当前节点就是要删除节点的前一个节点
        {
            if(current == null)
            {
                return 0; 
            }

            int indexLast = DiGui(current.next,n);
            if(indexLast == n)
            {
                current.next = current.next.next;

            }
            return indexLast+1;

        }


    }

}
