using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{



    internal class _2两数相加_链表_
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0); // 哨兵节点(必须这样写，重要！！！！)
            ListNode result = head;
            int carry = 0;
            int sum = 0; //sum表示每一轮计算的总和 sum = l1.val + l2.val + carray
            while(l1 != null || l2 != null || carry != 0)
            {
                sum = carry;
                if (l1 != null )
                {
                    sum += l1.val;
                    l1 = l1.next; //只有当前的l1不为Null的时候才更新l1为下一个节点
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                carry = sum / 10; //计算新一轮的carry
                int nextVal = sum % 10;
                result.next = new ListNode(nextVal); //必须这样写，先把next给建出来，再result = result.next;否则result会为null，会丢失
                result = result.next;

            }
            return head.next;
        }

    }
}
