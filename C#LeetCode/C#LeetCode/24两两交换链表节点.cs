using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _24两两交换链表节点
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

        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy;
            ListNode first;
            ListNode second;

            //first和second表示的是要交换的一组的第一个和第二个
            //假如交换3 和 4时，必须要保存着2，因为交换完3,4后，要重新修改2的指向为4，而不是3
            //current相当于是2 ， first相当于是3 , second相当于是4
            while (current.next != null && current.next.next != null) 
            {
                first = current.next;
                second = current.next.next;
                ListNode third = second.next;
                first.next = third;
                second.next = first;
                //完成first和second的交换后，修改current的指向为second而不是first
                current.next = second;

                //current重置为下一组的前一个(下一组分别是third 和 third.next , third的前一个此时是first)
                current = first; 
            }

            return dummy.next;
        }

    }
}
