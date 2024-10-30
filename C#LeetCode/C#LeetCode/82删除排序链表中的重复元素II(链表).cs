using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_LeetCode
{
    internal class _82删除排序链表中的重复元素II_链表_
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

        public ListNode DeleteDuplicates(ListNode head) 
        {
            ListNode dummy = new ListNode(0,head); //所有涉及到对头结点的删除等操作时，都要加一个哨兵节点            
            ListNode current = dummy;
            while (current.next != null && current.next.next != null) //current指向的是当前最后一个非重复的节点
            {
                if (current.next.val == current.next.next.val)//下一个节点是和下下个节点重复
                {
                    int x = current.next.val;
                    while (current.next != null && current.next.val == x) //跳过所有连续的等于x的节点，最终current.next指向的是第一个不等于x的节点
                    {
                        current.next = current.next.next; //不能一下跳两个节点，这样的话如果出现 1 2 2 2 3的情况，会出错，第三个2就跳不过了
                    }
                }
                else // 在内层while循环结束后，此时cur.next的节点并不一定是一个唯一节点,比如1 3 3 4 4 5这样的连续重复的数据，因此不能直接current = current.next，那样就会变成1 4 5 ，必须放在else中修改
                {
                    current = current.next;
                }

            }

            return dummy.next;

        }


    }
}
